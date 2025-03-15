namespace JwtTokenApp.Api.Models;

public static class Db
{
    public static Heroi[] Herois = ObterHerois();

    private static Heroi[] ObterHerois()
    {
        var homemNormal = new Heroi("Homem Normal", [SuperForça()]);

        var senhorContradicao = new Heroi("Senhor Contradição", [PodeVoar(), SuperVelocidade(), AtravessarParedes()]);

        var garotaMistério = new Heroi("Garota Mistério", [Invisibilidade(), InvisibilidadeComSom(), FalarComFantasmas()]);

        var doutorAnimal = new Heroi("Doutor Animal", [FalarComAnimais(), FalarComAliens()]);

        var aquaboi = new Heroi("Aquaboi", [RespirarDebaixoDaAgua(), ManipularFogo()]);

        var menteConfusa = new Heroi("Mente Confusa", [LeituraDeMente(), FalarComFantasmas(), Teleporte()]);

        var senhorTempo = new Heroi("Senhor Tempo", [ControlarTempo(), CuraInstantanea()]);

        var fantasmaAzul = new Heroi("Fantasma Azul", [AtravessarParedes(), Invisibilidade()]);

        var ouroFraco = new Heroi("Ouro Fraco", [TransmutarOuro(), SuperForça()]);

        var paradoxoVivo = new Heroi("Paradoxo Vivo", [PodeVoar(), Teleporte(), ControlarTempo(), LeituraDeMente()]);

        var mulherImprovável = new Heroi("Mulher Improvável", [SuperVelocidade(), RespirarDebaixoDaAgua(), AtravessarParedes()]);

        var garotoBugado = new Heroi("Garoto Bugado", [Teleporte(), PodeVoar(), AtravessarParedes(), ManipularFogo()]);

        return [
            homemNormal,
            senhorContradicao,
            garotaMistério,
            doutorAnimal,
            aquaboi,
            menteConfusa,
            senhorTempo,
            fantasmaAzul,
            ouroFraco,
            paradoxoVivo,
            mulherImprovável,
            garotoBugado
        ];
    }

    public const string PODER_DESCRICAO_PODE_VOAR = "Pode Voar, mas só consegue voar por uma distancia de 1 metro e somente a 1 metro do chão";
    public const string PODER_DESCRICAO_SUPER_VELOCIDADE = "Velocidade supersônica, mas só pode correr em linha reta e sem obstáculos (uma pedra no caminho já bloqueia)";
    public const string PODER_DESCRICAO_SUPER_FORCA = "Super força, mas só consegue levantar coisas leves (ex.: levanta uma pena como se fosse um prédio, mas um prédio continua impossível)";
    public const string PODER_DESCRICAO_INVISIBILIDADE = "Invisível, mas somente quando ninguém está olhando";
    public const string PODER_DESCRICAO_FALAR_COM_ANIMAIS = "Pode falar com animais, mas os animais odeiam ele e se recusam a responder";
    public const string PODER_DESCRICAO_RESPIRAR_DEBAIXO_DAGUA = "Respira debaixo d'água, mas não consegue segurar a respiração fora d'água por mais de 10 segundos";
    public const string PODER_DESCRICAO_TELEPORTE = "Teleporte, mas só consegue se teleportar para lugares que já está";
    public const string PODER_DESCRICAO_LEITURA_DE_MENTE = "Leitura de mente, mas só entende pensamentos em uma língua que não fala";
    public const string PODER_DESCRICAO_FALAR_COM_FANTASMAS = "Fala com fantasmas, mas eles só contam mentiras";
    public const string PODER_DESCRICAO_CURA_INSTANTANEA = "Cura instantânea, mas cada vez que se cura, esquece um fato importante da vida";
    public const string PODER_DESCRICAO_MANIPULAR_FOGO = "Manipula o fogo, mas tem medo de queimadura e não consegue usar de verdade";
    public const string PODER_DESCRICAO_CONTROLAR_TEMPO = "Controla o tempo, mas só pode voltar 1 segundo no passado";
    public const string PODER_DESCRICAO_INVISIBILIDADE_COM_SOM = "Pode ficar invisível, mas os sons que faz ficam super amplificados";
    public const string PODER_DESCRICAO_ATRAVESSAR_PAREDES = "Pode atravessar paredes, mas fica preso se a parede for pintada de azul";
    public const string PODER_DESCRICAO_TRANSMUTAR_OURO = "Transforma objetos em ouro, mas não consegue carregar nada de ouro";
    public const string PODER_DESCRICAO_FALAR_COM_ALIENS = "Comunicação com alienígenas, mas só em planetas a bilhões de anos-luz, sem chance de resposta a tempo";

    public static Poder PodeVoar() => new(PODER_DESCRICAO_PODE_VOAR);
    public static Poder SuperVelocidade() => new(PODER_DESCRICAO_SUPER_VELOCIDADE);
    public static Poder SuperForça() => new(PODER_DESCRICAO_SUPER_FORCA);
    public static Poder Invisibilidade() => new(PODER_DESCRICAO_INVISIBILIDADE);
    public static Poder FalarComAnimais() => new(PODER_DESCRICAO_FALAR_COM_ANIMAIS);
    public static Poder RespirarDebaixoDaAgua() => new(PODER_DESCRICAO_RESPIRAR_DEBAIXO_DAGUA);
    public static Poder Teleporte() => new(PODER_DESCRICAO_TELEPORTE);
    public static Poder LeituraDeMente() => new(PODER_DESCRICAO_LEITURA_DE_MENTE);
    public static Poder FalarComFantasmas() => new(PODER_DESCRICAO_FALAR_COM_FANTASMAS);
    public static Poder CuraInstantanea() => new(PODER_DESCRICAO_CURA_INSTANTANEA);
    public static Poder ManipularFogo() => new(PODER_DESCRICAO_MANIPULAR_FOGO);
    public static Poder ControlarTempo() => new(PODER_DESCRICAO_CONTROLAR_TEMPO);
    public static Poder InvisibilidadeComSom() => new(PODER_DESCRICAO_INVISIBILIDADE_COM_SOM);
    public static Poder AtravessarParedes() => new(PODER_DESCRICAO_ATRAVESSAR_PAREDES);
    public static Poder TransmutarOuro() => new(PODER_DESCRICAO_TRANSMUTAR_OURO);
    public static Poder FalarComAliens() => new(PODER_DESCRICAO_FALAR_COM_ALIENS);
}
