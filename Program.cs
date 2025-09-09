// See https://aka.ms/new-console-template for more information

Televisao tv = new Televisao(55f);

tv.LigarTv(false);
Console.WriteLine($"A TV tem o tamanho {tv.Tamanho}");

tv.GerenciarCanais(30);
Console.WriteLine($"Canal {tv.Canal}");

tv.GerenciarVolume(50);
Console.WriteLine($"Volume {tv.Volume}");

tv.AumentarVolume();
Console.WriteLine($"Volume {tv.Volume}");

tv.AumentarVolume();
Console.WriteLine($"Volume {tv.Volume}");

tv.DiminuirVolume();
Console.WriteLine($"Volume {tv.Volume}");

tv.ProximoCanal();
Console.WriteLine($"Canal {tv.Canal}");

tv.AtivarMudo(true);




