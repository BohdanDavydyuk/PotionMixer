using System.Collections.Generic;

public class EffectGroup
{
    public eEffectType EffectType { get; set; }

    public BaseRule Rule;

    public float CombineEffects(List<PreliminaryEffect> effects)
    {
        return Rule.Rule(effects);
    }
}

