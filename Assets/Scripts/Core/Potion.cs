using System.Collections.Generic;
using System.Linq;

public class Potion
{
    public List<Ingredient> Ingredients { get; set; }

    public List<FinalEffect> MixEffects()
    {
        var finalEffects = new List<FinalEffect>();

        foreach (var group in Ingredients.SelectMany(ingredient => ingredient.PreliminaryEffects).GroupBy(effect => effect.EffectGroup))
        {
            var combinedValue = group.Key.CombineEffects(group.ToList());

            finalEffects.Add(new FinalEffect
            {
                EffectType = group.Key.EffectType,
                Value = combinedValue
            });
        }

        return finalEffects;
    }
}

