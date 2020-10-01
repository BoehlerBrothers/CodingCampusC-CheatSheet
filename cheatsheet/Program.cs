using System;

namespace cheatsheet
{
    /**
     *  1. Variablen
     *  2. Eingabe/Ausgabe
     *  3. String
     *  4. Array
     *  5. Schleifen
     *  6. Methoden
     */
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*********************
             *    1.Variablen    *
             *********************/

            int i = 0;
            char c = 'c';
            string text = "Lorem Ipsum";
            Boolean isValid = true;
            int[] numbers = new int[7];
            int[] numbersWithValues = { 3, 2, 3, 4, 5, 6, 7 };
            int[] numbersConstructorAndValues = new int[] { 3, 2, 5, 4, 3, 2, 5, 6, 9, 10 };
            

            /*********************
             * 2.Eingabe/Ausgabe *
             *********************/

            /* Textausgabe mit Zeilenumbruch*/
            Console.WriteLine("Erste Zeile.");
            Console.WriteLine("Zweite Zeile.");

            /* Textausgabe ohne Zeilenumbruch*/
            Console.Write("Erste Zeile.");
            Console.WriteLine("Immernoch erste Zeile.");

            /* Texte zusammenhängen */
            Console.WriteLine("Hallo " + "Welt");
            /* Platzhalter ersetzten.*/
            /* {0} wird durch Hallo und {1} durch Welt ersetzt */
            Console.WriteLine("{0} {1}", "Hallo", "Welt") ;

            /**
             * Text einlesen
             */
            String userInput = Console.ReadLine();
            Console.WriteLine(userInput);

            /**
             * Zahl einlesen
             * ACHTUNG: Auch wenn eine Zahl eingegeben wird,
             * wird es von C# als String behandelt. Der String
             * muss zu einem int umgewandelt werden.
             */
            int numberInput = int.Parse(Console.ReadLine());
            Console.WriteLine(numberInput);

            /* Werte umwandeln */

            int textToInt = int.Parse("1");
            string intToText = "" + 1;
            double textToDouble = double.Parse("1.1");

            /*********************
             *      3.String     *
             *********************/

            string testText = "LOREM IPSUM";
            Console.WriteLine(testText);

            /* Replace characters:
             * Bestimmte Characters (Auch mehrere) werden
             * ersetzt durch andere.
             * Das Ergebnis wird zurück gegeben.
             */
            string replacedText = testText.Replace("OR", "AND");

            /* Lower characters/Upper characters
             * Alle Characters werden zu Klein/Großbuchstaben gemacht
             * und zurück gegeben
             */
            string onlySmallLetters = testText.ToLower();
            string onlyUpperLetters = testText.ToUpper();

            /**
             * Contains
             * überprüft, ob eine bestimmte Zeichenkette
             * im Text vorkommt.
             */
            Boolean isContaining = testText.Contains("L"); //->true

            /*********************
             *      4.Array      *
             *********************/

            int[] numbersToPrint = new int[] { 3, 2, 5, 4, 3, 2, 5, 6, 9, 10 };
            /* Länge des Arrays
             * nützlich wenn wir über jede Stelle des Arrays gehen wollen (Iterieren)
             */
            Console.WriteLine(numbersToPrint.Length); // -> Das Array hat die Länge 10

            /* Einzelnes Element ausgeben */
            int numberFromArray = numbersToPrint[0];

            /* Einen Wert zuweisen */
            numbersToPrint[0] = 324;

            /* Alle Werte augeben */
            for(int index = 0; index < numbersToPrint.Length; index++)
            {
                Console.WriteLine(numbersToPrint[index]);
            }

            String textHello = "Hello";
            for(int j = 0; j < textHello.Length; j++)
            {
                Console.Write(textHello[j] + ",");
            }
            //Output -> H,e,l,l,o,
            Console.WriteLine(""); //linebreak

            
            /*********************
             *    4.Schleifen    *
             *********************/

            /* For Schleifen */
            for(int k = 0; k < 10; k++)
            {
                Console.WriteLine(k);
            }

            foreach(char singleChar in "text")
            {
                Console.WriteLine(singleChar + ",");
            }
            //Output -> t,e,x,t,
            Console.WriteLine(""); //linebreak

            //Whileschleifen
            Boolean runLoop = true;

            while(runLoop)
            {
                runLoop = false;
            }
        }
    }
}
