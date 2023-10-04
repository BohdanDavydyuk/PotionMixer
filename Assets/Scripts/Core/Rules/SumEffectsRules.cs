using System.Collections.Generic;
using System.Linq;

public class SumEffectsRule : BaseRule
{
    public override float Rule(List<PreliminaryEffect> effects)
    {
        return effects.Sum(effect => effect.Value);
    }
}