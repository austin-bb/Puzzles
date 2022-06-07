static void RandomArray(){
  Console.WriteLine("****************************************************");
  int[] randArray = new int[10];
  var rand = new Random();
  
  for (int i = 0; i < randArray.Length; i++) {
    randArray[i] = rand.Next(5, 25);
    // Console.WriteLine(randArray[i]);
  }

  foreach (int num in randArray) {
    Console.WriteLine(num);
  }

  int min = 0;
  int max = 0;
  int sum = 0;

  for (int i = 0; i < randArray.Length; i++) {
    if (min == 0) {
      min = randArray[i];
    } else if (randArray[i] < min) {
      min = randArray[i];
    } else if (randArray[i] > max) {
      max = randArray[i];
    }
    sum += randArray[i];
  }

  Console.WriteLine("Min value = " + min + " | " + "Max value = " + max + " | " + "Sum = " + sum);
}

RandomArray();


static void CoinToss() {
  Console.WriteLine("******************* Tossing a Coin! *******************");
  var rand = new Random();
  int coinFlip = rand.Next(0, 100);
  string result = "";

  if (coinFlip % 2 == 0) {
    result = "Heads";
  } else {
    result = "Tails";
  }
  
  Console.WriteLine("Flip result is " + result);
}

CoinToss();


static void Names() {
  Console.WriteLine("****************************************************");

  List<string> names = new List<string>();
  names.Add("Todd");
  names.Add("Tiffany");
  names.Add("Charlie");
  names.Add("Geneva");
  names.Add("Sydney");

  foreach (string name in names) {
    if (name.Length > 5) {
      Console.WriteLine("This name is longer than 5 characters " + name);
    }
  }
}

Names();



