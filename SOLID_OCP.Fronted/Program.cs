using SOLID_OCP.Backend;


Vehicle moto = new Vehicle("NKD", "GRAY", 20000, 2010);
Vehicle camion = new Vehicle("NHR", "RED", 100000, 2011);
Vehicle electric = new Vehicle("BYD", "BLUE", 5000, 2026);

MotoInspection motoInspection = new MotoInspection();
motoInspection.Inspect(moto);

CamionInspection camionInspection = new CamionInspection();
camionInspection.Inspect(camion);

ElectricInspection electricInspection = new ElectricInspection();
electricInspection.Inspect(electric);

