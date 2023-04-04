using System;
public class Persona
{
    public int DNI{get;private set;}
    public string apellido{get;set;}
    public string nombre{get;set;}
    public DateTime fechaNacimiento{get;set;}
    public string email{get;set;}
    private int edad{get;set;}

public Persona(string nom, string apell,string em, int dni=0,DateTime fn = new DateTime())
    {
        apellido = apell;
        nombre = nom;
        DNI=dni;
        fechaNacimiento = fn;
        email = em;
        edad = 0;
    }
    public int obtenerEdad()
    {
        DateTime FechaNacimientoHoy = new DateTime(DateTime.Today.Year, fechaNacimiento.Month, fechaNacimiento.Day);
        if (FechaNacimientoHoy< DateTime.Today)  edad = DateTime.Today.Year - fechaNacimiento.Year;
            else   edad = DateTime.Today.Year - fechaNacimiento.Year -1;
        return edad; 
    }
    public bool puedeVotar()
    {
        bool votar = false;
if (edad >= 16)
{
votar = true;
} 
return votar;
    }
}

