public class Televisao{

    private const int VOL_MAX = 100;
    private const int VOL_MIN = 0;
    private const int CANAL_MAX = 520;
    private const int CANAL_MIN = 1;
    public Televisao(float tamanho){
        Tamanho = tamanho;
    }

    public float Tamanho {get;}
    public int Resolucao {get; set;}
    public int Volume {get; private set;}
    public int Canal {get; set;}
    public bool Estado {get; set;}
    public bool Mudo {get; set;}

    public int GerenciarVolume(int volume){
        Volume = volume;
        if(volume > VOL_MAX || volume < VOL_MIN){
            Console.WriteLine("Volume máximo atingido!");
        }

        return Volume;
    }

    public void AumentarVolume(){
        if(Volume < VOL_MAX){
            Volume++;
        } else {
            Console.WriteLine("TV já está no volume máx.");
        }
    }

    public void DiminuirVolume(){
        if(Volume > VOL_MIN){
            Volume--;
        } else{
            Console.WriteLine("TV está no mudo!");
        }
    }

    public int GerenciarCanais(int canal){
        Canal = canal;
        if(Canal < 0 || Canal > 520){
            Console.WriteLine("Este canal não existe!");
        }

        return Canal;
    }

    public void ProximoCanal(){
        if(Canal < CANAL_MAX){
            Canal++;
        } else{
            Console.WriteLine("Não existem mais canais!");
        }
    }

    public void CanalAnterior(){
        if(Canal > CANAL_MIN){
            Canal--;
        } else{
            Console.WriteLine("Não existem mais canais!");
        }
    }

    public void LigarTv(bool Estado){
        if(Estado == true){
            Console.WriteLine("A TV está ligada!");
        } else{
            Console.WriteLine("Ligue a televisão!");
            Resolucao = 0;
            Canal = 0;
            Volume = 0;
        }
    }

    public void AtivarMudo(bool Mudo){
        if(Mudo == true){
            Volume = VOL_MIN;
            Console.WriteLine("TV está no mudo!");
        }
    }


}