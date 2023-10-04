using System.Collections.Generic;
using UnityEngine;

public class PotionMixer : MonoBehaviour
{
    private void Start()
    {
        var healthGroup = new EffectGroup
        {
            EffectType = eEffectType.Health,
            Rule = new SumEffectsRule(),
        };

        var attributeGroup = new EffectGroup
        {
            EffectType = eEffectType.Attribute,
            Rule = new MaxValueRule(),
        };

        var ingredientFirst = new Ingredient
        {
            PreliminaryEffects = new List<PreliminaryEffect>
            {
                new PreliminaryEffect { Value = 10, EffectGroup = healthGroup },
                new PreliminaryEffect { Value = 20, EffectGroup = attributeGroup }
            }
        };

        var ingredientSecond = new Ingredient
        {
            PreliminaryEffects = new List<PreliminaryEffect>
            {
                new PreliminaryEffect { Value = 5, EffectGroup = healthGroup },
                new PreliminaryEffect { Value = 30, EffectGroup = attributeGroup }
            }
        };

        var potion = new Potion
        {
            Ingredients = new List<Ingredient> { ingredientFirst, ingredientSecond }
        };

        var finalEffects = potion.MixEffects();

        foreach (var effect in finalEffects)
        {
            Debug.Log($"{effect.EffectType} {effect.Value}"); // Health 15, Attribute 30
        }
    }

}