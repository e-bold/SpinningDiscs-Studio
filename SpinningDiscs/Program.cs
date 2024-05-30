using SpinningDiscs;

CD cd = new CD("CD example", 700, "CD-R", 350);
DVD dvd = new DVD("DVD example", 4700, "DVD-R", 1450);

cd.SpinDisc();
dvd.SpinDisc();

cd.ReadData();
cd.WriteData(350);

dvd.ReadData();
dvd.WriteData(3250);




Console.WriteLine(cd.DiskInfo());
Console.WriteLine(dvd.DiskInfo());