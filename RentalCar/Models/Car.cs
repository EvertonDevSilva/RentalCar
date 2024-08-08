namespace RentalCar.Models
{
    public class Car(string brand, string place, decimal kmInitial, decimal kmFinal, bool isRended)
    {
        public int Id { get; set; }
        public string Brand { get; set; } = brand;
        public string Place { get; set; } = place;
        public decimal KmInitial { get; set; } = kmInitial;
        public decimal KmFinal { get; set; } = kmFinal;
        public bool IsRended {  get; set; } = isRended;

        public void UpdateCar(Car car)
        {
            this.Brand = car.Brand;
            this.Place = car.Place;
            this.KmInitial = car.KmInitial;
            this.KmFinal = car.KmFinal;
            this.IsRended = car.IsRended;
        }

        public void IsRendedAlter(bool isRended)
        {
            this.IsRended = isRended;
        }
    }
}
