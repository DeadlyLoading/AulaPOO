using UnityEngine;

public interface IPersonagem
{
    public void ReceberDano(int dano);
    public void gritar();
    public void conversar(string mensagem);
}
