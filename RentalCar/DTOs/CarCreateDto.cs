namespace RentalCar.DTOs
{
    public class CarCreateDto
    {
        public string Brand { get; set; } = string.Empty;
        public string PlaceId { get; set; } = string.Empty;
        public decimal KmInitial { get; set; }
    }
}
