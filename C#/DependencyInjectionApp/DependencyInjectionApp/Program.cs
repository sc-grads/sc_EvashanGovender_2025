using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionApp
{

    public interface  IToolUser
    {
        void SetHammer(Hammer hammer);
        void SetSaw(Saw saw);
    }
    public class Hammer
    {
        public void Use()
        {
           Console.WriteLine("Hammering Nails!");
        }
    }

    public class Builder: IToolUser
    {
        //public Hammer hammer { get; set; }

       // public Saw saw { get; set; }

         private  Hammer _hammer;// Used for Constructor Dependency Injection and Interface Dependency Injection
         private  Saw _saw;// Used for Constructor Dependency Injection and Interface Dependency Injection

        //Constructor Dependency Injection
        /*public Builder(Hammer hammer, Saw saw)
        {
            _hammer = hammer;
            _saw = saw; 
        }*/

        public void SetHammer(Hammer hammer)
        {
            _hammer = hammer;
        }

        public void SetSaw(Saw saw)
        {
            _saw = saw;
        }
        public void BuildHouse()
        {
            _hammer.Use();
            _saw.Use();
            Console.WriteLine("Building something...");
           
        }
    }

    public class  Saw
    {
        public void Use()
        {
            Console.WriteLine("Using Saw!");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Hammer and Saw
            /* Hammer hammer = new Hammer();
             Saw saw = new Saw();
             // Inject dependencies into Builder
             Builder builder = new Builder(hammer, saw);// Used for Constructor Dependency Injection
             // Use the Builder to build a house
             builder.BuildHouse();*/

            // Using Property Dependency Injection
            /*Hammer hammer = new Hammer();
            Saw saw = new Saw();
            Builder builder = new Builder();
            builder.hammer = hammer; // Injecting Hammer dependency via setters
            builder.saw = saw; // Injecting Saw dependency via setters
            // Use the Builder to build a house
            builder.BuildHouse();*/

            // Using Interface Dependency Injection
            Hammer hammer = new Hammer();
            Saw saw = new Saw();
            Builder builder = new Builder();
            builder.SetHammer(hammer); // Injecting Hammer dependency via interface method
            builder.SetSaw(saw); // Injecting Saw dependency via interface method
            // Use the Builder to build a house
            builder.BuildHouse();

            Console.ReadLine();
        }
    }
}
