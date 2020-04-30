using System;
using Classes;

namespace VehicleSalon
{
    class Program
    {
        //Салон за продажба на возила:
        //1. 3 типа на возила: Автомобили, Комбиња и Камиони
        //2. Тежина на возилот, бројот на гуми, Зафатнина на мотор
        //- Автомобил: Кожа да/не, Металик боја да/не, Сензори за паркирање да/не
        //- Комбе: носивост, Автоматик да/не
        //- Камион: Колку приколку може да влече
        //3. Пресметка на цена:
        //- Автомобил: тежина на возилот + зафатнина на моторот + (ако е кожа внатрешноста +1000е) + (ако е металик +500е) + (ако има сензори +1500е)
        //- Комбе: (тежина на возилот + зафатнина на моторот) * 2 + носивост + (3000е ако е аутоматик)
        //- Камион: зафатнина на моторот* 5 + (за секоја приколка што може да ја влече + 10000е)
        static void Main(string[] args)
        {
            Salon salon = new Salon("Avto Cajka");

            //Vans
            //Mercedes Benz Sprinter  210 D (2874 cc, 3,000kg, 1455)
            //Mercedes Benz Sprinter  208 D (2299 cc, 3,000kg, 1500)

            Van van1 = new Van("Mercedes Benz", "Sprinter 210 D", 3000, 4, 2874, 1455, false);
            Van van2 = new Van("Mercedes Benz", "Sprinter 208 D", 3000, 4, 2299, 1500, true);

            salon.AddVehicle(van1);
            salon.AddVehicle(van2);

            //Trucks
            //MAN Truck 1 (6,871 cc, 8, 1)
            //MAN Truck 1 (6,900 cc, 8.5, 2)

            Truck truck1 = new Truck("MAN", "1", 8000, 6, 6871, 1);
            Truck truck2 = new Truck("MAN", "2", 8500, 6, 6000, 2);

            salon.AddVehicle(truck1);
            salon.AddVehicle(truck2);

            //Cars
            //Audi A8 (2995 cc, 1,945)
            Car car = new Car("Audi", "A8", 1945, 4, 2995, InteriorType.Leather, ColorType.Plain, true);

            salon.AddVehicle(car);

            Console.WriteLine(salon.GetCatalog());
        }
    }
}
