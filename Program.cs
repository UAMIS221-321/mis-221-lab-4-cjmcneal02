//start main
MainMenu();

//end main


static void MainMenu()
{
bool exit = false;
while (!exit)//conditional to run until user chooses to exit 
{
    Console.WriteLine("Welcome to Crimson Crust Pizza");
    Console.WriteLine("Press 1 to see no toppings");
    Console.WriteLine("Press 2 to see cheese pizza");
    Console.WriteLine("Press 3 to see pepperoni pizza");
    Console.WriteLine("Press 4 to exit");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    string userInput = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

    switch (userInput)
    {//execute code based on user inputs
        case "1":
            Console.WriteLine("Displaying Topping-less Slice");
            PlainPizza();
            break;
        case "2":
            Console.WriteLine("Displaying Cheese-Pizza Slice");
            CheesePizza();
            break;
        case "3":
            Console.WriteLine("Displaying Pepperoni-Pizza Slice");
            PepperoniPizza();
            break;
        case "4":
            Console.WriteLine("Thanks for Choosing Crimson Crust Pizza!");
            exit = true; //exit becomes true, ending program
            break;
        default:
            Console.WriteLine("Invalid option entered. Please try again.");
            break;




    }


}
//plain pizza code 
}
static void PlainPizza()
{
    Random random = new Random();
    int rows = random.Next(8,13); //random # 8-12
    {
        for (int i = 1; i <= rows; i++) //loop to control rows
        {
            for (int j =1; j<= i; j++) //inner loop to control # of asterisks
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
//cheese pizza code
static void CheesePizza(){
    Random random = new Random();
    int rows = random.Next(8,13);//8-12

    char outsideCharacter = '*';//outline       
    char insideCharacter = '#';//inside

    for(int i=0; i<rows; i++)
    {
        for(int j = 0; j<=i;j++)
        {
            if (j == 0 || i == rows-1 || j == i) //check to see if position is part of outline. (first column check, last row check,index check )
            {
                Console.Write(outsideCharacter +" ");
            }else{
                Console.Write(insideCharacter + " ");
            }
            }
        System.Console.WriteLine();
        }
    }

//pepperoni pizza

static void PepperoniPizza()
{
Random random = new Random();
int rows = random.Next(8,13);

char outsideCharacter = '*';
char cheeseCharacter = '#';
string pepperoniCharacter = "[]"; //cannot use "char" becasue more than one character is listed

for(int i = 0; i < rows; i++)
{
    for(int j = 0; j <= i; j++)
    {
        if ( i==rows-1 ||j==0||j==i)
        {
            Console.Write(outsideCharacter + "" );
        }else
        {
            if (random.Next(0,3)==0)//chance of pepperoni = 33%
            {
                Console.WriteLine(pepperoniCharacter+" ");
            }else
            {
                Console.WriteLine(cheeseCharacter+" ");
            }
         }
          System.Console.WriteLine(" ");
         }
         Console.WriteLine();
        }
    }
//codei s outputting pizza as line???