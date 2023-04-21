// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Practice Array
// 1. Copying an array
void copyArray(){
    int[] array1 = new int[10]{1,2,3,4,5,6,7,8,9,10};
    int[] array2 = new int[array1.Length];
    for(int i = 0; i < array1.Length; i++){
        array2[i] = array1[i];
    }
    Console.WriteLine("Array 1: ");
    foreach(int i in array1){
        Console.Write(i + " ");
    }
}


// 2. to do list
void toDoList() {
Console.WriteLine("\nEnter command (+ item, - item, -- to clear or exit to exit)):");
string command = Console.ReadLine();
string[] commandArray = command.Split(" ");
string[] toDoList = new string[10];
int toDoListIndex = 0;
while(command != "exit"){
    
    if(commandArray[0] == "+"){
        String[] targetArr = new String[commandArray.Length - 1];
        Array.Copy(commandArray, 1, targetArr, 0, commandArray.Length - 1);
        string item = String.Join(" ", targetArr);
        toDoList[toDoListIndex] = item;
        toDoListIndex++;
    }
    else if(commandArray[0] == "-"){
        for(int i = 0; i < toDoList.Length; i++){
            String[] targetArr = new String[commandArray.Length - 1];
            Array.Copy(commandArray, 1, targetArr, 0, commandArray.Length - 1);
            string item = String.Join(" ", targetArr);
            if(toDoList[i] == item){
                toDoList[i] = null;
            }
        }
    }
    else if(command == "--"){
        for(int i = 0; i < toDoList.Length; i++){
            toDoList[i] = null;
        }
    }

    if (toDoList.Length!= 0) {
        // Print the to do list
        Console.WriteLine("To do list:");
        foreach(string item in toDoList){
            if(item != null){
                Console.WriteLine(item);
            }
        }
    }
    Console.WriteLine("\nEnter command (+ item, - item, or -- to clear)):");
    command = Console.ReadLine();
    commandArray = command.Split(" ");
}
}
// 3 Find primes in a range
static int[] FindPrimesInRange(int startNum, int endNum){
    int[] primes = new int[0];
    for(int i = startNum; i <= endNum; i++){
        if(isPrime(i)){
            Array.Resize(ref primes, primes.Length + 1);
            primes[primes.Length - 1] = i;
        }
    }
    printPrimes(primes);
    return primes;
}

static bool isPrime(int num){
    if(num == 1){
        return false;
    }
    for(int i = 2; i < num; i++){
        if(num % i == 0){
            return false;
        }
    }
    return true;
}

static void printPrimes(int[] primes){
    Console.WriteLine("Primes: ");
    foreach(int prime in primes){
        Console.Write(prime + " ");
    }
}

// 4. rotate array k times and sum the obtained array
static int[] rotateArray(int[] arr, int k){
    int[] rotatedArr = new int[arr.Length];
    for(int i = 0; i < arr.Length; i++){
        int newIndex = (i + k) % arr.Length;
        rotatedArr[newIndex] = arr[i];
    }
    return rotatedArr;
}

// read array and k from console
static void readArrayAndK(){
    Console.WriteLine("Enter the array: ");
    string arrayString = Console.ReadLine();
    string[] arrayStringArray = arrayString.Split(" ");
    int[] array = new int[arrayStringArray.Length];
    for(int i = 0; i < arrayStringArray.Length; i++){
        array[i] = Convert.ToInt32(arrayStringArray[i]);
    }
    Console.WriteLine("Enter k: ");
    int k = Convert.ToInt32(Console.ReadLine());
    sumRotatedArray(array, k);
}

// store rotated array for each rotation in an array and sum it
static void sumRotatedArray(int[] arr, int k) {
    int[][] rotatedArrays = new int[k][];
    for(int i = 0; i < k; i++){
        rotatedArrays[i] = rotateArray(arr, i + 1);
    }
    int[] sumArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++){
        int sum = 0;
        for(int j = 0; j < k; j++){
            sum += rotatedArrays[j][i];
        }
        sumArray[i] = sum;
    }
    Console.WriteLine("Sum of rotated array: ");
    foreach(int i in sumArray){
        Console.Write(i + " ");
    }
}

// 5. find the longest sequence of equal elements in an array
// 4 4 5 5 5 6 6 6 6
static int[] findLongestSequence(int[] arr){
    int[] longestSequence = new int[0];
    int[] currentSequence = new int[0];
    if (arr.Length == 0){
        return longestSequence;
    }
    for(int i = 0; i < arr.Length-1; i++){
        if(arr[i] == arr[i + 1]){
            Array.Resize(ref currentSequence, currentSequence.Length + 1);
            currentSequence[currentSequence.Length - 1] = arr[i];
        }
        // } else {
        if(currentSequence.Length > longestSequence.Length){
            longestSequence = currentSequence;
             
        } else {
            currentSequence = new int[0];
        }
        // }
    }
    return longestSequence;
}
// read array from console and print the longest sequence
static void readArrayAndPrintLongestSequence(){
    Console.WriteLine("Enter the array: ");
    string arrayString = Console.ReadLine();
    string[] arrayStringArray = arrayString.Split(" ");
    int[] array = new int[arrayStringArray.Length];
    for(int i = 0; i < arrayStringArray.Length; i++){
        array[i] = Convert.ToInt32(arrayStringArray[i]);
    }
    int[] longestSequence = findLongestSequence(array);
    Console.WriteLine("Longest sequence: ");
    foreach(int i in longestSequence){
        Console.Write(i + " ");
    }
}

// 7. Write a program that finds the most frequent number in a given sequence of numbers. In
// case of multiple numbers with the same maximal frequency, print the leftmost of them
static int findMostFrequentNumber(int[] arr){
    int mostFrequentNumber = arr[0];
    int mostFrequentNumberCount = 0;
    for(int i = 0; i < arr.Length; i++){
        int currentNumber = arr[i];
        int currentNumberCount = 0;
        for(int j = i; j < arr.Length; j++){
            if(arr[j] == currentNumber){
                currentNumberCount++;
            }
        }
        if(currentNumberCount > mostFrequentNumberCount){
            mostFrequentNumber = currentNumber;
            mostFrequentNumberCount = currentNumberCount;
        }
    }
    return mostFrequentNumber;
}

static void readFromConsole() {
    Console.WriteLine("Enter the array: ");
    string arrayString = Console.ReadLine();
    string[] arrayStringArray = arrayString.Split(" ");
    int[] array = new int[arrayStringArray.Length];
    for(int i = 0; i < arrayStringArray.Length; i++){
        array[i] = Convert.ToInt32(arrayStringArray[i]);
    }
    int mostFrequentNumber = findMostFrequentNumber(array);
    Console.WriteLine("Most frequent number: " + mostFrequentNumber);
}

// String exercises
//1.  Convert the string to char array, reverse it, then convert it to string again
static string reverseString(string str){
    char[] charArray = str.ToCharArray();
    Array.Reverse(charArray);
    String result = charArray.ToString()!;
    return result;
}

// Print the letters of the string in back direction (from the last to the first) in a for-loop
static void printStringBackwards(string str){
    for(int i = str.Length - 1; i >= 0; i--){
        Console.Write(str[i]);
    }
}

static void readAndPrintReverseString(){
    Console.WriteLine("Enter the string: ");
    string str = Console.ReadLine();
    string reversedString = reverseString(str);
    Console.WriteLine("Method 1 Reversed string: " + reversedString);
    Console.WriteLine("Method 2 Reversed string: ");
    printStringBackwards(str);
}

//2.reverses the words in a given sentence
// input: C# is not C++, and PHP is not Delphi!
// output: Delphi not is PHP, and C++ not is C#!
static string reverseWordsInSentence(string sentence){
     String sign = "";
    if (sentence.EndsWith("!") || sentence.EndsWith(".") || sentence.EndsWith("?")){
        sign = sentence.Substring(sentence.Length - 1);
        sentence = sentence.Substring(0, sentence.Length - 1);
    }
    string[] words = sentence.Split(" ");
    string[] reversedWords = new string[words.Length];
    for(int i = 0; i < words.Length; i++){
        reversedWords[i] = words[words.Length - 1 - i];
    }
    string reversedSentence = String.Join(" ", reversedWords);
    reversedSentence += sign;
    return reversedSentence;
}

//read and print the reversed sentence
static void readAndPrintReversedSentence(){
    Console.WriteLine("Enter the sentence: ");
    string sentence = Console.ReadLine();
    string reversedSentence = reverseWordsInSentence(sentence!);
    Console.WriteLine("Reversed sentence: " + reversedSentence);
}

// 3. given a sentence, split it into words and check wether each word is a palindrome
static bool isPalindrome(string word){
    char[] charArray = word.ToCharArray();
    int i = 0;
    int j = charArray.Length - 1;
    while(i < j){
        if(charArray[i] != charArray[j]){
            return false;
        }
        i++;
        j--;
    }
    return true;
}

static void readAndPrintPalindromes(){
    Console.WriteLine("Enter the sentence: ");
    string sentence = Console.ReadLine();
    string[] words = sentence.Split(' ', ',', '.', '?', '!', ':');
    foreach(string word in words){
        if(isPalindrome(word) && word.Length >= 1){
            Console.Write(word + ", ");
        }
    }
}

// 4. parse url
static void parseUrl(){
    Console.WriteLine("Enter the url: ");
    string url = Console.ReadLine();
    string[] urlParts = url.Split("://");
    string protocol = urlParts[0];
    string server = urlParts[1].Split("/")[0];
    string resource = urlParts[1].Substring(server.Length + 1);
    Console.WriteLine("Protocol: " + protocol);
    Console.WriteLine("Server: " + server);
    Console.WriteLine("Resource: " + resource);
}

Console.WriteLine("Enter the function you want to run (\ncopyArray \ntoDoList \nFindPrimesInRange \nRotateArray \nfindLongestSequence " +
"\nfindMostFrequentNumber \nreverse string \nreverse sentence \nget palindrome words \nparse url): ");
string function = Console.ReadLine();
if(function == "copyArray"){
    copyArray();
}
else if(function == "toDoList"){
    toDoList();
} 
else if(function == "FindPrimesInRange"){
    Console.WriteLine("Enter the start number: ");
    int startNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the end number: ");
    int endNum = Convert.ToInt32(Console.ReadLine());
    FindPrimesInRange(startNum, endNum);
} else if (function == "RotateArray"){
    readArrayAndK();
} else if (function == "findLongestSequence"){
    readArrayAndPrintLongestSequence();
} else if (function == "findMostFrequentNumber") {
    readFromConsole();
} else if (function == "reverse string"){
    readAndPrintReverseString();
} else if (function == "reverse sentence"){
    readAndPrintReversedSentence();
} else if (function == "get palindrome words"){
    readAndPrintPalindromes();
}
else if (function == "parse url"){
    parseUrl();
}
else {
    Console.WriteLine("Invalid function name");
}

