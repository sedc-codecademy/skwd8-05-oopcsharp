# Homework Class08

## 1. Create class Car. The Car should have:
 * Id (randomly generated)
 * Brand
 * Model
 * Doors
 * TopSpeed
 * Consumption(economic, medium, high) - **enum**
 * EngineType (petrol, diesel, electric) - **enum**
 * PrintInfo(method that prints info about the car)


## 2. Create class ElectricCar that inherits from Car. Should have:
 * BatteryCapacity
 * BatteryUsage(percentage of used battery)
 * Drive - method that takes distance as parameter and calculates how much of the battery has been used (distance * consumption(economic - 1, medium - 2, high - 3) / 10)
 * Recharge(method that charges the battery of the car, it takes one parameter minutes, 10 minutes charges 1 percent of the battery)

## 3. Create class FuelCar that extends Car. Should have:
 * FuelCapacity
 * CurrentFuel(fuel in tank)
 * Drive - method that takes distance as parameter and calculates how much fuel has been used (distance * consumption(economic - 1, medium - 2, high - 3) / 10)
 * Refuel(method that fills the tank with fuel, should take fuel as parameter and shouldn't exceed fuel capacity)

## Bonus
 * When Drive method is called the car should not be allowed to drive more than the capacity of their battery, fuel tank
 * EngineType enum should be given default by derived classes
 * If charging succeeds battery capacity should print "Can't charge longer that n minutes"
 * If refueling method exceeds fuel capacity should print message "Can't refuel more than n litres"

## Create electric and fuel cars, drive them and recharge/refuel them with both correct and incorrect values, check if battery usage and current fuel properties return correct values
