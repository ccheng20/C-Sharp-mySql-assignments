// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 1. reverse an array
int[] GenerateNumbers(int n){
    int[] numbers = new int[n];
    for (int i = 0; i < numbers.Length; i++) {
        numbers[i] = i + 1;
    }
    return numbers;
}

void Reverse(int[] numbers) {
int start = 0;
    int end = numbers.Length - 1;

    while (start < end)
    {
        int temp = numbers[start];
        numbers[start] = numbers[end];
        numbers[end] = temp;

        start++;
        end--;
    }
}

void PrintNumbers(int[] numbers) {
    for (int i = 0; i < numbers.Length; i++) {
        Console.WriteLine(numbers[i]);
    }
}

int[] numbers = GenerateNumbers(7);
Reverse(numbers);
PrintNumbers(numbers);
Console.WriteLine("*********************************");

// 2. Fibonacci function
int Fibonacci(int n) {
    int[] numbers = new int[n];
    numbers[0] = 1;
    numbers[1] = 1;

    for (int i = 2; i < n; i++) {
        numbers[i] = numbers[i - 1] + numbers[i - 2];
    }

    return numbers[n-1];
}

Console.WriteLine("*********************************");

int fiboResult = Fibonacci(3);
int fiboResultTwo = Fibonacci(5);
Console.WriteLine("This is the fibonacci result of input 3 : " + fiboResult);
Console.WriteLine("This is the fibonacci result of input 5 : " + fiboResultTwo);

// created a instance of Instructor class and ComputerScience class which inherits from Department class
Instructor instructor = new Instructor("John", "Doe", 123, "Computer Science", new DateTime(1980, 1, 1), 1000, new DateTime(2010, 1, 1));
instructor.addAddress("123 Main St");
ComputerScience cs = new ComputerScience();
cs.setHeadOfDepartment(instructor);
Console.WriteLine(cs.getHeadOfDepartment().GetFullName());


Console.WriteLine("*********************************");
//create Ball object
Color red25 = new Color(255, 0, 0, 25);
Ball ball = new Ball(4.5, red25);
Console.WriteLine("Ball color is " + ball.getColor().getRed() + " in red");
ball.throwBall();
ball.throwBall();
Console.WriteLine("Number of ball thrown is " + ball.getNumberThrown());
ball.popBall();
Console.WriteLine("Ball size is " + ball.getSize());
Console.WriteLine("Number of ball thrown after pop is " + ball.getNumberThrown());



