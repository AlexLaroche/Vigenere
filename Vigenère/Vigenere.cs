using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vigenère
{
    /// <summary>
    /// Vigenere
    /// </summary>
    public static class Vigenere
    {
        /// <summary>
        /// Letters frequency in a text by language
        /// </summary>
        public static readonly Dictionary<string, Vigenere.Language> LETTER_FREQUENCY = new Dictionary<string, Vigenere.Language>()
        {
            { "English", new Vigenere.Language(26, 0.0667, new double[] { 0.08167, 0.01492, 0.02782, 0.04253, 0.12702, 0.02228, 0.02015, 0.06094, 0.06966, 0.00153, 0.00772, 0.04025, 0.02406, 0.06749, 0.07507, 0.01929, 0.00095, 0.05987, 0.06327, 0.09056, 0.02758, 0.00978, 0.02360, 0.00150, 0.01974, 0.00074 } ) },
            { "French", new Vigenere.Language(26, 0.0778, new double[] { 0.08173, 0.00901, 0.03345, 0.03669, 0.16734, 0.01066, 0.00866, 0.00737, 0.07579, 0.00613, 0.00049, 0.05456, 0.02968, 0.07095, 0.05819, 0.02521, 0.01362, 0.06693, 0.07948, 0.07244, 0.06369, 0.01838, 0.00074, 0.00427, 0.00128, 0.00326 } ) }
        };

        /// <summary>
        /// Language
        /// </summary>
        public class Language
        {
            private int _numberLetters;
            private double _idc;
            private double[] _frequencies;

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="idc"></param>
            /// <param name="frequency"></param>
            public Language(int numberLetters, double idc, double[] frequency)
            {
                this._numberLetters = numberLetters;
                this._idc = idc;
                this._frequencies = frequency;
            }

            public int NumberOfLetters
            {
                get { return this._numberLetters; }
            }

            /// <summary>
            /// Index of coincidence
            /// </summary>
            public double IndexOfCoincidence
            {
                get { return this._idc; }
            }

            /// <summary>
            /// Letter frequencies
            /// </summary>
            public double[] LetterFrequencies
            {
                get { return this._frequencies; }
            }
        }

        /// <summary>
        /// Encrypt the cleartext message
        /// </summary>
        /// <param name="cleartext"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Encrypt(string cleartext, string key)
        {
            return Vigenere.ProcessKey(cleartext, key, 1);
        }

        /// <summary>
        /// Decrypt the ciphertext message
        /// </summary>
        /// <param name="ciphertext"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Decrypt(string ciphertext, string key)
        {
            return Vigenere.ProcessKey(ciphertext, key, -1);
        }

        /// <summary>
        /// Encrypt/Decrypt process
        /// </summary>
        /// <param name="text"></param>
        /// <param name="key"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        private static string ProcessKey(string text, string key, int d, int letterNumbers = 26)
        {
            StringBuilder sb = new StringBuilder(text);

            for (int i = 0; i < sb.Length; i++)
                sb[i] = Char.ToUpper(sb[i]);

            key = key.ToUpper();

            int j = 0;
            for (int i = 0; i < sb.Length; i++)
            {
                if (Char.IsLetter(sb[i]))
                {
                    int tmp = sb[i] - 65 + d * (key[j] - 65);

                    if (tmp < 0)
                        tmp += letterNumbers;

                    sb[i] = Convert.ToChar(65 + (tmp % letterNumbers));

                    if (++j == key.Length)
                        j = 0;
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Friedman test
        /// </summary>
        /// <param name="ciphertext"></param>
        /// <param name="language"></param>
        /// <param name="results"></param>
        /// <param name="maxKeyLength"></param>
        /// <returns></returns>
        public static int FriedmanTest(string ciphertext, string language, out Dictionary<int, List<double>> results, int maxKeyLength = 16)
        {
            results = new Dictionary<int, List<double>>();
            double languageIdc = Vigenere.LETTER_FREQUENCY[language].IndexOfCoincidence;
            double average = 0;
            double probableKeyAverage = 0;
            int probableKeyLength = 0;

            for (int keyLength = 2; keyLength <= maxKeyLength; keyLength++)
            {
                average = 0;

                results[keyLength] = new List<double>();

                for (int offset = 0; offset < keyLength; offset++)
                {
                    double idc = Vigenere.IndexOfCoincidence(ciphertext, offset, keyLength);
                    results[keyLength].Add(idc);
                    average += idc;
                }

                average = average / keyLength;

                if(Math.Abs(languageIdc - average) < Math.Abs(languageIdc - probableKeyAverage))
                {
                    probableKeyLength = keyLength;
                    probableKeyAverage = average;
                }
            }

            return probableKeyLength;
        }

        /// <summary>
        /// Guess key
        /// </summary>
        /// <param name="ciphertext"></param>
        /// <param name="keyLength"></param>
        /// <returns></returns>
        public static string GuessKey(string ciphertext, int keyLength, string language)
        {
            char[] key = new char[keyLength];
            int numberLetters = Vigenere.LETTER_FREQUENCY[language].NumberOfLetters;

            // METHOD 1 : Using language frequency for mutual indices of coincidence for all cipher vectors
            for (int offset = 0; offset < keyLength; offset++)
            {
                double[] indices = new double[numberLetters];
                double[] frequencies = Vigenere.Frenquencies(ciphertext, offset, keyLength).Select(Convert.ToDouble).ToArray();

                indices = Vigenere.MutualIndicesOfCoincidence(Vigenere.LETTER_FREQUENCY[language].LetterFrequencies, 1, frequencies, frequencies.Sum());

                int bestShift = 0;
                for (int shift = 1; shift < numberLetters; shift++)
                    if (indices[shift] > indices[bestShift])
                        bestShift = shift;

                key[offset] = (char)(bestShift + 65);
            }

            // METHOD 2 : Using reference vector for mutual indices of coincidence for all other cipher vectors
            /*double[] frequenciesLang = Vigenere.LETTER_FREQUENCY[language].LetterFrequencies;
            double[] frequenciesRef = Vigenere.Frenquencies(ciphertext, 0, keyLength).Select(Convert.ToDouble).ToArray();
            double lengthRef = frequenciesRef.Sum();

            double[] indices = new double[numberLetters];
            indices = Vigenere.MutualIndicesOfCoincidence(frequenciesLang, 1, frequenciesRef, lengthRef);

            int shiftRef = 0;
            for (int i = 1; i < numberLetters; i++)
                if (indices[i] > indices[shiftRef])
                    shiftRef = i;

            key[0] = (char)(shiftRef + 65);

            for (int offset = 1; offset < keyLength; offset++)
            {
                double[] frequenciesCmp = Vigenere.Frenquencies(ciphertext, offset, keyLength).Select(Convert.ToDouble).ToArray();
                double lengthCmp = frequenciesRef.Sum();

                indices = Vigenere.MutualIndicesOfCoincidence(frequenciesRef, lengthRef, frequenciesCmp, lengthCmp);

                int bestShift = 0;
                for (int i = 1; i < numberLetters; i++)
                    if (indices[i] > indices[bestShift])
                        bestShift = i;

                key[offset] = (char)((bestShift + shiftRef) % numberLetters + 65);
            }*/

            return new string(key);
        }

        /// <summary>
        /// Calculate index of coincidence
        /// </summary>
        /// <param name="ciphertext"></param>
        /// <param name="offset"></param>
        /// <param name="keyLength"></param>
        /// <returns></returns>
        private static double IndexOfCoincidence(string ciphertext, int offset, int keyLength, int numberLetters = 26)
        {
            double index = 0;
            int length = 0;

            int[] frequences = Vigenere.Frenquencies(ciphertext, offset, keyLength);

            for (int k = 0; k < numberLetters; k++)
            {
                index += frequences[k] * (frequences[k] - 1);
                length += frequences[k];
            }

            return index / (length * (length - 1));
        }

        /// <summary>
        /// Calculate mutual indices of coincidence
        /// </summary>
        /// <param name="frequencies1"></param>
        /// <param name="length1"></param>
        /// <param name="frequencies2"></param>
        /// <param name="length2"></param>
        /// <returns></returns>
        private static double[] MutualIndicesOfCoincidence(double[] frequencies1, double length1, double[] frequencies2, double length2, int numberLetters = 26)
        {
            double[] indices = new double[numberLetters];       

            for (int i = 0; i < numberLetters; i++)
            {
                for (int j = 0; j < numberLetters; j++)
                    indices[i] += frequencies1[j] * frequencies2[(i + j) % numberLetters];

                indices[i] /= length1 * length2;
            }

            return indices;
        }

        /// <summary>
        /// Calculate letter frequencies
        /// </summary>
        /// <param name="ciphertext"></param>
        /// <param name="offset"></param>
        /// <param name="keyLength"></param>
        /// <returns></returns>
        private static int[] Frenquencies(string ciphertext, int offset, int keyLength, int numberLetters = 26)
        {
            int[] frenquences = new int[numberLetters];

            for (int i = offset; i < ciphertext.Length; i += keyLength)
                frenquences[ciphertext[i] - 65]++;

            return frenquences;
        }
    }
}