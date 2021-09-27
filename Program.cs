namespace Vehicles
{
    /* Class: Vehicle
     * Author: Jonathan Karcher
     * Purpose: Creates a vehicle parent class
     */
    public abstract class Vehicle
    {
        /* Method: LoadPassanger
         * Purpose: Load a passenger
         * Restrictions: None
         */
        public virtual void LoadPassanger()
        {

        }
    }
    /* Class: Car
     * Author: Jonathan Karcher
     * Purpose: Creates a car class
     */
    public abstract class Car : Vehicle
    {

    }
    /* Class: Train
     * Author: Jonathan Karcher
     * Purpose: Creates a train class
     */
    public abstract class Train : Vehicle
    {

    }
    /* Interface: IPassengerCarrier
     * Author: Jonathan Karcher
     * Purpose: Defines a vehicle type that is meant to carry passengers
     */
    public interface IPassengerCarrier
    {
        // a reference to the parent LoadPassanger
        void LoadPassanger();
    }
    /* Interface: IHeavyLoadCarrier
     * Author: Jonathan Karcher
     * Purpose: Defines a vehicle type that is meant to carry a heavy load
     */
    public interface IHeavyLoadCarrier
    {

    }
    /* Class: Compact
     * Author: Jonathan Karcher
     * Purpose: Create a Compact object
     */
    public class Compact : Car, IPassengerCarrier
    {
        /* Method: LoadPassanger
         * Purpose: load a passenger from the parent
         * Restrictions: None
         */
        public void LoadPassanger()
        {

        }
    }
    /* Class: SUV
     * Author: Jonathan Karcher
     * Purpose: Create a SUV object
     */
    public class SUV : Car, IPassengerCarrier
    {
        /* Method: LoadPassanger
         * Purpose: load a passenger from the parent
         * Restrictions: None
         */
        public void LoadPassanger()
        {

        }
    }
    /* Class: Pickup
     * Author: Jonathan Karcher
     * Purpose: Create a Pickup object
     */
    public class Pickup : Car, IPassengerCarrier, IHeavyLoadCarrier
    {
        /* Method: LoadPassanger
         * Purpose: load a passenger from the parent
         * Restrictions: None
         */
        public void LoadPassanger()
        {

        }
    }
    /* Class: PassengerTrain
     * Author: Jonathan Karcher
     * Purpose: Create a PassengerTrain object
     */
    public class PassengerTrain : Train, IPassengerCarrier
    {
        /* Method: LoadPassanger
         * Purpose: load a passenger from the parent
         * Restrictions: None
         */
        public void LoadPassanger()
        {

        }
    }
    /* Class: FreightTrain
     * Author: Jonathan Karcher
     * Purpose: Create a FreightTrain object
     */
    public class FreightTrain : Train, IHeavyLoadCarrier
    {

    }
    /* Class: _424DoubleBogey
     * Author: Jonathan Karcher
     * Purpose: Create a _424DoubleBogey object
     */
    public class _424DoubleBogey : Train, IHeavyLoadCarrier
    {

    }
    /* Class:Pprogram
     * Author: Jonathan Karcher
     * Purpose: Entery class for the dll
     */
    class Program
    {
        /* Method: Main
         * Purpose: Entery point for the dll
         * Restrictions: None
         */
        static void Main(string[] args)
        {

        }
    }
}
