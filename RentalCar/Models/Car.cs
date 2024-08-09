namespace RentalCar.Models
{
    public class Car(string brand, string placeId, decimal kmInitial)
    {
        public int Id { get; set; }
        public string Brand { get; private set; } = brand;
        public string PlaceId { get; private set; } = placeId;
        public decimal KmInitial { get; private set; } = kmInitial;
        public decimal KmFinal { get; private set; } = 0;
        public bool IsRended {  get; private set; } = false;

        public void UpdateCar(string brand, string placeId, decimal kmInitial, decimal kmFinal, bool isRended)
        {
            this.Brand = brand;
            this.PlaceId = placeId;
            this.KmInitial = kmInitial;
            this.KmFinal = kmFinal;
            this.IsRended = isRended;
        }

        public void IsRendedAlter(bool isRended)
        {
            this.IsRended = isRended;
        }
    }
}
