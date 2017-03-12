public enum CarType {
    Generic,
    Truck,
    Van,
}

public enum CarEngine {
    Petrol,
    Hybrid,
    Electric
}

public class Car {
    public string id { get; set; }
    public string CarNumber { get; set; }       // matrícula de coche
    public CarType Type { get; set; }           // tipo de coche
    public string YearOfBuild { get; set; }     // año de fabricación 
    public string Manufacturer { get; set; }    // fabricante
    public string Model { get; set; }           // modelo
    public CarEngine Engine { get; set; }       // tipo de combustible
}