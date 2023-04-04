List<Persona> listaPersonas = new List<Persona>();
int menu = 0;
while(menu != 5){
    Console.WriteLine("1. Cargar nueva persona");
    Console.WriteLine("2. Obtener estadisticas del censo");
    Console.WriteLine("3. Buscar persona");
    Console.WriteLine("4. Modificar mail de una persona");
    Console.WriteLine("5. Salir");
    menu = int.Parse(Console.ReadLine());
switch(menu)
{
case 1:
{
cargarPersona();

    break;
}
case 2:
{
    ObtenerEstadisticas();
    break;
}
case 3:
{
   buscarPersona();
    break;
}
case 4:
{
    modificarMail();
    break;
}
case 5:
{
    
    break;
}
}
void cargarPersona()
{
    string em = " ";
   int  d = 0;
   bool existe = false;
   int dni = 0;
    while (!existe){
      dni = Funciones.IngresarEntero("Ingrese DNI");
    existe=BuscarDNI(dni);
    }
string nom = Funciones.IngresarTexto("Ingrese Nombre");
string apell = Funciones.IngresarTexto("Ingrese apellido");
while(em.IndexOf('@') == -1)
{
 em = Funciones.IngresarTexto("Ingrese email");
 if (em.IndexOf('@') == -1){
    Console.WriteLine("tu email debe llevar @, vuelve a ingresarlo");
 }
}


DateTime fn = Funciones.IngresarFecha("Ingrese Fecha de Nacimiento (aaaa/mm/dd)");

Persona UnaPersona =  new Persona(nom,apell,em,dni,fn);
listaPersonas.Add(UnaPersona);
Console.WriteLine("Se ha creado la persona " + UnaPersona.nombre + UnaPersona.apellido + " y se ha agregado a la lista.");
}
}
bool BuscarDNI(int dni)
{
    foreach (Persona d in listaPersonas)
      {
        if(d.DNI == dni)
        {
            Console.WriteLine("Dni existe en la lista");
            return false;
        }
      }
      return true;

}
void ObtenerEstadisticas()
{
    int contVotar = 0;
    int sumaEdades= 0;
    double promedioEdad =0;
    while(listaPersonas.Count > 0){
Console.WriteLine("La cantidad de personas en la lista son: " + listaPersonas.Count);
foreach (Persona unPerson in listaPersonas)
{
    if(unPerson.puedeVotar() == true)
    {
     contVotar++;
    }
}
Console.WriteLine("La cantidad de personas admitidas para votar son: " + contVotar);
    }
    if (listaPersonas.Count == 0){
Console.WriteLine("Aún no se ingresaron personas en la lista” si la lista está vacía.");
    }
foreach (Persona edadPersona in listaPersonas)
{
  sumaEdades = edadPersona.obtenerEdad()+ sumaEdades;
    
}
promedioEdad = sumaEdades/listaPersonas.Count;
Console.WriteLine("El promedio de edad de las personas es: " + promedioEdad);

}

void buscarPersona() 
{
    int i = 0;
bool existeDni = false;
Console.WriteLine("Ingresar dni deseado a buscar");
int dniIngresado = int.Parse(Console.ReadLine());
while(!existeDni)
{
if (listaPersonas[i].DNI == dniIngresado)
{
existeDni = true;
} else
{
i++;
}
if (!existeDni)
{
Console.WriteLine("No se encuentra el DNI en la lista");
}
}
Console.WriteLine("el apellido es " + listaPersonas[i].apellido);
Console.WriteLine("el nombre es " + listaPersonas[i].nombre);
Console.WriteLine("el dni es " + listaPersonas[i].DNI);
Console.WriteLine("la fecha de nacimiento es " + listaPersonas[i].fechaNacimiento);
Console.WriteLine("el email es " +listaPersonas[i].email);
Console.WriteLine("la edad es " +listaPersonas[i].obtenerEdad());
}
void modificarMail()
{
    int i = 0;
bool existeDni = false;
Console.WriteLine("Ingresar dni para cambiar mail");
int dniIngresado = int.Parse(Console.ReadLine());
while(!existeDni)
{
if (listaPersonas[i].DNI == dniIngresado)
{
existeDni = true;
} else
{
i++;
}
if (!existeDni)
{
Console.WriteLine("No se encuentra el DNI en la lista");
}
Console.WriteLine("Ingresar mail para cambiar");
string nuevoMail = Console.ReadLine();
listaPersonas[i].email = nuevoMail;
}
}