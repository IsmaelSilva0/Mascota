namespace Tamagochi;
public class Mascota
{
    public int nivel {get; protected set;}
    public IEstado Estado {get; protected set;}
    public Mascota (int nivel, IEstado estado);

    public void Jugar()=> Estado.Comer(this);
    public void Comer()=> Estado.Jugar(this);
    public void CambiarDeEstado(IEstado estado)
    =>this.Estado = estado;
    
    public void IncrementarNivel(int nivel)
    =>this.nivel = nivel;
}
