using Patos.Domains;

Pato_Corredor pato_corredor = new();
Pato_Maratonista pato_maratonista = new(); 

Console.WriteLine(pato_corredor.Mostrar());
Console.WriteLine(pato_corredor.Grasnar());
Console.WriteLine(pato_corredor.Comportamento_pato_correr());
Console.WriteLine("-------------------------------------------s");

Console.WriteLine(pato_maratonista.Mostrar());
Console.WriteLine(pato_maratonista.Grasnar());
Console.WriteLine(pato_maratonista.Comportamento_pato_maratonar());