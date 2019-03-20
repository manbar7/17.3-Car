using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Garage : IGarage
    {
        private List<Car> Cars = new List<Car>();
        private List<String> CarTypes = new List<string>();

        public object CarNullExcetion { get; private set; }

        public Garage(List<string> carTypes)
        {

            CarTypes = carTypes;
        }

        public void AddCar(Car c)
        {
            if (c == null)           
                throw new CarNullExcetion();            
            if (Cars.Contains(c))
                throw new CarAlreadyHereException();
            if (c.TotalLost)
                throw new WeDoNotFixTotalLostException();
            if (!CarTypes.Contains(c.Brand))
                throw new WrongGarageException();
            if (!c.NeedsRepair)
                throw new RepairMismatchEception();
            else            
            Cars.Add(c);
        }
        public void TakeOutCar(Car c)
        {
            if (c == null)           
                throw new CarNullExcetion();
            if (!Cars.Contains(c))
                throw new CarNotInGarageException();
            if (c.NeedsRepair)
                throw new CarNotReadyException();
            else
            Cars.Remove(c);
        }
        public bool FixCar(Car c)
        {
            if (c == null)
                throw new CarNullExcetion();
            if (!Cars.Contains(c))
                throw new CarNotInGarageException();
            if (!c.NeedsRepair)
                throw new RepairMismatchEception();
            return !c.NeedsRepair;
        }

    }
}
