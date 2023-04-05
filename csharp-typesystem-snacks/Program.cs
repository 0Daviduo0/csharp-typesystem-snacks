
//// --------- es. 1 --------- //
///
//    // chiedo il primo numero
//    Console.Write("Inserisci un numero:");
//    // controllo che sia un numero e poi lo salvo 
//    int numero1;
//        while (!int.TryParse(Console.ReadLine(), out numero1))
//        {
//            Console.WriteLine("ci hai provato! Inserisci un numero >:(");
//        }


//    // chiedo il secondo numero
//    Console.Write("Inserisci un altro numero:");
//    // controllo che sia un numero e poi lo salvo 
//    int numero2;
//        while (!int.TryParse(Console.ReadLine(), out numero2))
//        {
//            Console.WriteLine("ci hai provato! Inserisci un numero >:(");
//        }

//    // Controllo fra i due numeri quale è il più grande e lo stampo nel terminale
//    int numeroGrandissimoIncredibile = (numero1 > numero2) ? numero1 : numero2;
//        Console.WriteLine("il numero più grande fra i due è: " + numeroGrandissimoIncredibile);


// --------- es. 2 --------- //
////Chiedo la prima parola
//  Console.Write("Inserisci la prima parola: ");
//  string parola1 = Console.ReadLine();

////Chiedo la seconda parola
//  Console.Write("Inserisci la seconda parola: ");
//  string parola2 = Console.ReadLine();

////Valuto la lunghezza delle parole
//  string parolaCorta = (parola1.Length < parola2.Length) ? parola1 : parola2;
//  string parolaLunga = (parola1.Length >= parola2.Length) ? parola1 : parola2;

////le stampo distinguendole in base alla lunghezza
//  Console.WriteLine("La parola più corta è: " + parolaCorta);
//  Console.WriteLine("La parola più lunga è: " + parolaLunga);


// --------- es. 3 --------- //

//  int somma = 0;

////Ciclo per richiedere 10 numeri all'utente e sommarli fra di loro
//  for (int i = 0; i < 10; i++)
//  {
//      Console.WriteLine("Devi scrivere 10 numeri, scrivi il " + (i+1) + "o numero: ");
//      int numero = Convert.ToInt32(Console.ReadLine());
//      somma += numero;
//  }

////Ricavo la somma di tutti i numeri e la stampo
//  Console.WriteLine("La somma dei numeri inseriti è: " + somma);


// --------- es. 4 --------- //

//  int somma = 0;
//  int NdiN_Sommati = 0;
////Ciclo che somma la variabile i da 2 a 10, e tiene conto di tutte le volte che avviene questo processo
//  for (int i = 2; i <= 10; i++)
//  {
//      somma += i;
//      NdiN_Sommati++;
//  }
//////Faccio la media e poi stampo sia la somma che la media
//  int media = somma / NdiN_Sommati;
//  Console.WriteLine("La somma dei numeri da 2 a 10 è: " + somma);
//  Console.WriteLine("La media dei numeri da 2 a 10 è: " + media);


// --------- es. 5 --------- //

//  Console.Write("Inserisci un numero: ");
//  int numero = Convert.ToInt32(Console.ReadLine());
//  if (numero % 2 == 0) // se è pari
//  {
//      Console.WriteLine("Il numero che hai inserito, " + numero + ", è pari! :D");
//  }
//  else // se non è pari
//  {
//      Console.WriteLine("Il numero che hai inserito, " + numero + ", non era pari :(, quindi ho preso il numero pari successivo per te: " + (numero+1) + ", prego non c'è di che 😎");
//  }


// --------- es. 6 --------- //

////Creo l'array di invitati
//  string[] invitati = 
//      { 
//          "Roborto", 
//          "Peppo", 
//          "Sbrugolo", 
//          "Alborgo", 
//          "Amogus",
//          "RiccardoZanottiQuelloDeiPinguiniTattici",
//          "Valentona",
//          "Paolo",
//      };

////Chiedo il nome alla persona
//  Console.Write("Vediamo se sei invitato! Scrivi il tuo nome: ");
//  string nome = Console.ReadLine();

//Controllo se è contenuto nell'array e dò una risposta a seconda dei casi
//  if (invitati.Contains(nome))
//  {
//      Console.WriteLine("----------------------------------------------");
//      Console.WriteLine("|YEY Puoi entrare, sbrigati, fuori c'è freddo|");
//      Console.WriteLine("----------------------------------------------");
//  }
//  else
//  {
//      Console.WriteLine("----------------------------------");
//      Console.WriteLine("|Get the fuck out of here paesant|");
//      Console.WriteLine("----------------------------------");
//  }


// --------- es. 7 --------- //

//// Creo array vuoto e variabile int
//  var numeriDispariArr = Array.Empty<int>();
//  int numero = 0;

//// Ciclo for per chiedere 6 volte un numero, controllare che sia effettivamente un numero e poi controllare che sia dispari e successivamente metterlo all'interno dell'array
//  for (int i = 0; i < 6; i++)
//  {
//      Console.Write("Inserisci un numero: ");
//      while (!int.TryParse(Console.ReadLine(), out numero))
//      {
//          Console.WriteLine("ci hai provato! Inserisci un numero >:(");
//      }
//      if (numero % 2 != 0)
//      {
//          Array.Resize(ref numeriDispariArr, numeriDispariArr.Length + 1);
//          numeriDispariArr[numeriDispariArr.Length - 1] = numero;
//      }
//  }
//// Stampo il contenuto dell'array
//  Console.WriteLine("I numeri contenuti nell'array sono:");
//  for (int i = 0; i < numeriDispariArr.Length; i++)
//  {
//      Console.WriteLine("-" + (i+1) + "o numero dell'Array: " + numeriDispariArr[i]);
//  }


// --------- es. 8 --------- //

//  int[] numeri =
//        { 
//            3,        //0 
//            213,      //1 
//            435,      //2
//            2,        //3
//            67568564, //4
//            56395,    //5
//            345423,   //6
//            78689,    //7
//        };
//  int somma = 0;

////Il ciclo for parte da 1 e va avanti a salti di 2 in modo da prendere solo gli elementi in posizione dispari
//  for (int i = 1; i<numeri.Length; i+=2)
//  {
//      somma += numeri[i];
//  }

//  Console.WriteLine("Somma degli elementi in posizione dispari: " + somma);


// --------- es. 9 --------- //

//  var numeriArr = Array.Empty<int>();
//  int numero;
//  int somma = 0;

//  while (somma < 50)
//  {

//      Console.Write("Inserisci un numero: ");
//      while (!int.TryParse(Console.ReadLine(), out numero))
//      {
//          Console.WriteLine("ci hai provato! Inserisci un numero >:(");
//      }
//      somma += numero;
//      Console.WriteLine("somma: " + somma);
//      Array.Resize(ref numeriArr, numeriArr.Length + 1);
//      numeriArr[numeriArr.Length - 1] = numero;

//      foreach (int x in numeriArr)
//      {
//          Console.WriteLine("numero dell'Array: " + x);
//      }
//  }


// --------- es. 10 --------- //

//int N;
//int[] numeri;

//Console.Write("Inserisci il numero di array che vuoi creare: ");
//    while (!int.TryParse(Console.ReadLine(), out N))
//          {
//              Console.WriteLine("ci hai provato! Inserisci un numero >:(");
//          }

//    Random rnd = new Random();

//    for (int i = 0; i < N; i++)
//    {
//        numeri = new int[10]; // Crea un nuovo array contenente 10 elementi

//        for (int x = 0; x < 10; x++)
//        {
//            numeri[x] = rnd.Next(1, 101); // 10 Numeri random da 1 a 10 da inserire nell'array appena creato
//        }

//        Console.WriteLine("Array {0}: {1}", i + 1, string.Join(", ", numeri)); // Stampa dell'array appena creato
//    }


// --------- es. 11 --------- //

////Chiedo la prima parola
//  Console.Write("Inserisci la prima parola: ");
//  string parola1 = Console.ReadLine();

////Chiedo la seconda parola
//  Console.Write("Inserisci la seconda parola: ");
//  string parola2 = Console.ReadLine();

////richiamo la funzione per valutare la lungezza delle parole
//  contatoreParole(parola1, parola2);

//  static void contatoreParole(string a, string b)
//  {
//      string parolaLunga = (a.Length > b.Length) ? a : b;
//              Console.WriteLine("la parola più lunga fra le due è: " + parolaLunga);
//  }


// --------- es. 12 --------- //

    // chiedo il primo numero
    Console.Write("Inserisci un numero:");
    // controllo che sia un numero e poi lo salvo 
    int numero1;
        while (!int.TryParse(Console.ReadLine(), out numero1))
        {
            Console.WriteLine("ci hai provato! Inserisci un numero >:(");
        }

controlloPariDispari(numero1);

static void controlloPariDispari(int a)
{
    if (a % 2 == 0) // se è pari
    {
        Console.WriteLine("Il numero " + a + "è pari");
    }
    else
    {
        Console.WriteLine("Il numero " + a + " è dispari");
    }
}
   





