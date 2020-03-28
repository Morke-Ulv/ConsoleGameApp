using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGames
{
    public class Randy
    {
        public void Randomizer()
        {
            Random rnd = new Random();
            int randomRoom = rnd.Next(1, 11);
            switch (randomRoom)
            {
                case 1:
                    SurpriseAttack();
                    break;
                case 2:
                    AstroidField();
                    break;
                case 3:
                    Void();
                    break;
                case 4:
                    FoundAnEnemy();
                    break;
                case 5:
                    MedShip();
                    break;
                case 6:
                    FuelBay();
                    break;
                case 7:
                    Console.WriteLine("Energy Recharge?");
                    break;
                case 8:
                    FoundAnEnemy();
                    break;
                case 9:
                    SurpriseAttack();
                    break;
                case 10:
                    FoundAnEnemy();
                    break;
            }
        }

        public void SurpriseAttack()
        {
            bool surpriseAttack = true;
            while (surpriseAttack)
            {
            Console.Clear();
            Console.WriteLine("CAPTAIN WE ARE UNDER ATTACK!!!!!!\n" +
                "WHAT ARE YOUR ORDERS SIR?!?!?");
            Console.WriteLine("Return Fire? Flee?");
            string orders = Console.ReadLine();

                switch (orders)
                {
                    case "Return Fire":
                        Console.WriteLine("Yes sir!");
                        surpriseAttack = false;
                        break;
                    case "Flee":
                        Console.WriteLine("Getting us out of here Captain!");
                        //random next room cost more fuel
                        surpriseAttack = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("CAPTAIN PLEASE REPEAT!!!!");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void AstroidField()
        {
            bool astroidField = true;
            while (astroidField)
            {
                Console.Clear();
                Console.WriteLine("Sir, we are enter an astroid field,\n" +
                    "what are your orders?\n" +
                    "Evasive Maneuvers? Retreat?");
                string orders = Console.ReadLine();
                switch (orders)
                {
                    case "Evasive Maneuvers":
                        Console.WriteLine("Taking Evasive Manuevers");
                        astroidField = false;
                        break;
                    case "Retreat":
                        Console.WriteLine("Returning to previous galaxy");
                        astroidField = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Could you please repeat Captain");
                        Console.ReadKey();
                        break;
                }
            }
        }


        public void Void()
        {
            Console.Clear();
            Console.WriteLine("There is nothing to report Captain");
        }

        public void FoundAnEnemy()
        {
            bool foundAnEnemy = true;
            while (foundAnEnemy)
            {
                Console.Clear();
                Console.WriteLine("Sir, Enemy on Radar.\n" +
                    "what are your orders Captain?\n" +
                    "Engage? Retreat? Ignore?");
                string orders = Console.ReadLine();
                switch (orders)
                {
                    case "Engage":
                        Console.Clear();
                        Console.WriteLine("Enaging enemy");
                        foundAnEnemy = false;
                        break;
                    case "Retreat":
                        Console.Clear();
                        Console.WriteLine("Disengaging enemy");
                        foundAnEnemy = false;
                        break;
                    case "Ignore":
                        Console.Clear();
                        Console.WriteLine("Ignoring the enemy");
                        foundAnEnemy = false;
                        break;
                    default:
                        Console.WriteLine("Please repeat Sir.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void MedShip()
        {
            bool medShip = true;
            while (medShip)
            {
                Console.Clear();
                Console.WriteLine("Med ship up ahead Captain shall we stop?\n" +
                    "Yes? No?");
                string orders = Console.ReadLine();
                switch (orders)
                {
                    case "Yes":
                        Console.Clear();
                        Console.WriteLine("Stoping for ship repairs this may take a little time Captain");
                        medShip = false;
                        break;
                    case "No":
                        Console.Clear();
                        Console.WriteLine("Continuing on Sir.");
                        medShip = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please repeat Sir");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void FuelBay()
        {
            bool fuelBay = true;
            while (fuelBay)
            {
                Console.Clear();
                Console.WriteLine("Sir, there is a fuel bay ahead shap we stop and refuel?\n" +
                    "Yes? No?");
                string orders = Console.ReadLine();
                switch (orders)
                {
                    case "Yes":
                        Console.Clear();
                        Console.WriteLine("Refueling, this may take a little time Captain");
                        fuelBay = false;
                        break;
                    case "No":
                        Console.Clear();
                        Console.WriteLine("Continuing on Sir.");
                        fuelBay = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please repeat Sir");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void EnergyStation()
        {

        }
    }
}
