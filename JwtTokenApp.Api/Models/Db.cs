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

    public static Poder PodeVoar() => new("Pode Voar, mas só consegue voar por uma distancia de 1 metro e somente a 1 metro do chão");
    public static Poder SuperVelocidade() => new("Velocidade supersônica, mas só pode correr em linha reta e sem obstáculos (uma pedra no caminho já bloqueia)");
    public static Poder SuperForça() => new("Super força, mas só consegue levantar coisas leves (ex.: levanta uma pena como se fosse um prédio, mas um prédio continua impossível)");
    public static Poder Invisibilidade() => new("Invisível, mas somente quando ninguém está olhando");
    public static Poder FalarComAnimais() => new("Pode falar com animais, mas os animais odeiam ele e se recusam a responder");
    public static Poder RespirarDebaixoDaAgua() => new("Respira debaixo d'água, mas não consegue segurar a respiração fora d'água por mais de 10 segundos");
    public static Poder Teleporte() => new("Teleporte, mas só consegue se teleportar para lugares que já está");
    public static Poder LeituraDeMente() => new("Leitura de mente, mas só entende pensamentos em uma língua que não fala");
    public static Poder FalarComFantasmas() => new("Fala com fantasmas, mas eles só contam mentiras");
    public static Poder CuraInstantanea() => new("Cura instantânea, mas cada vez que se cura, esquece um fato importante da vida");
    public static Poder ManipularFogo() => new("Manipula o fogo, mas tem medo de queimadura e não consegue usar de verdade");
    public static Poder ControlarTempo() => new("Controla o tempo, mas só pode voltar 1 segundo no passado");
    public static Poder InvisibilidadeComSom() => new("Pode ficar invisível, mas os sons que faz ficam super amplificados");
    public static Poder AtravessarParedes() => new("Pode atravessar paredes, mas fica preso se a parede for pintada de azul");
    public static Poder TransmutarOuro() => new("Transforma objetos em ouro, mas não consegue carregar nada de ouro");
    public static Poder FalarComAliens() => new("Comunicação com alienígenas, mas só em planetas a bilhões de anos-luz, sem chance de resposta a tempo");
}
