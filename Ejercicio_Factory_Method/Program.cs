using Ejercicio_Factory_Method;

BebidaEnergizante oBebida = Creador.CreadorBebida(Creador.GATORADE);
Console.WriteLine(oBebida.CuantoMeEnergizaPorHora());