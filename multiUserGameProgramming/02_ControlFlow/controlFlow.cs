// Malik Amrullah, v0.04

using system;

namespace ControlFlow
{  
    class controlFlow
    {
       static void Main(string[] args);
       {
        // Declarations
        string favColor = "blu";
        int luckyNumber = 7;
        float myGPA = 3.54;
        int myage = 17;
        bool pineappleOnPizza = true;

        // if statment --  check for a singal condition
        if (favColor == "green") {
            Console.WriteLine("green with envy!");
        }

         if (myage == "17") {
            Console.WriteLine(" almost there");
        }
         if (luckyNumber % 2 == 0) {
            Console.WriteLine(" Your number is Even !");
        }

        // if - else statments -- checks for singal condition, but has two
        if (myage > 15){
            console.WriteLine("you are able to drive");
        } else{
            console.WriteLine("Walk");
        }
        //if -- else if -- else -- checks multiple outcomes
        if( myGPA == 4.0f){
            console.WriteLine(" congrats on all A's");
        } else if (myGPA >= 3.0f){
            console.WriteLine(" congrats on the honor roll");
        } else if (myGPA >= 2.0f){
            console.WriteLine(" you are grad ready!");
        } else  (myGpa >= 1.0f){
            console.WriteLine(" you need to study");
        }


        //Nested statments
       
        if(pineappleOnPizza == true){
            Console.writeline("Ew, that gross. how old are you");
            if(myage > 60){
                console.writeline("how was it like having a dinosaur growing up");
            } else {
                Console.writeline("Your not old, you have a bad taste in food")
            }
        }

       
       }
    }
}