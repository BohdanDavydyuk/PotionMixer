using System.Collections.Generic;
using System.Linq;

public class MaxValueRule : BaseRule
{
    public override float Rule(List<PreliminaryEffect> effects)
    {
        return effects.Max(effect => effect.Value);
    }
}