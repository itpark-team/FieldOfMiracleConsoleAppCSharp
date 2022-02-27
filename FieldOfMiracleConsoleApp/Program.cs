using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOfMiracleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. объявление переменных
            const char HIDDEN_SYMBOL = '*';

            char[] hiddenWord, guessWord;
            string hintPhrase;
            char inputSymbol;
            bool playGame;

            //2. введение загаднного слова
            Console.Write("введите загаданное слово: ");
            hiddenWord = Console.ReadLine().ToCharArray();

            //2.5 инициализация отгадываемого слова
            guessWord = new string(HIDDEN_SYMBOL, hiddenWord.Length).ToCharArray();

            //3. введение подсказки
            Console.Write("введите подсказку: ");
            hintPhrase = Console.ReadLine();

            Console.Write("данные успешно сохранены, для продолжения нажмите <Enter> ");
            Console.ReadKey();

            playGame = true;

            while (playGame)
            {
                //3.5 очистка экрана
                Console.Clear();

                Console.WriteLine("Я загадал слово, ниже вывдена подсказка, твоя задача отгадать это слово");
                //4. вывод подсказки
                Console.WriteLine($"Подсказка: {hintPhrase}");

                //5. вывод отгаданного слова (вместо НЕ отгаданных букв *)
                Console.Write("Отгаданное слово: ");
                Console.WriteLine(guessWord);

                //6. ввод предполагаемой буквы
                Console.Write("введите предполагаемую букву: ");
                //inputSymbol = char.Parse(Console.ReadLine());
                inputSymbol = Console.ReadKey().KeyChar;

                //7. проверка вхождения предполагаемой буквы в строке
                bool symbolExist = false;

                for (int i = 0; i < hiddenWord.Length; i++)
                {
                    if (hiddenWord[i] == inputSymbol)
                    {
                        guessWord[i] = inputSymbol;
                        symbolExist = true;
                    }
                }

                Console.WriteLine();
                if (symbolExist == true)
                {
                    Console.WriteLine("такая буква есть в загаданном слове");
                }
                else
                {
                    Console.WriteLine("такой буквы нет в загаданном слове");
                }

                Console.ReadKey();

                bool hiddenSymbolsExist = false;
                for (int i = 0; i < guessWord.Length; i++)
                {
                    if (guessWord[i] == HIDDEN_SYMBOL)
                    {
                        hiddenSymbolsExist = true;
                        break;
                    }
                }

                playGame = hiddenSymbolsExist;
            }
            //8. повтор пунктов 4-7 пока все буквы не будут отгаданы

            Console.Clear();
            Console.WriteLine(guessWord);
            Console.WriteLine("поздравляем вы отгадали слово, для завершения нажмите <Enter> ");
            Console.ReadKey();
        }
    }
}
