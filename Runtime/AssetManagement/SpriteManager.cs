/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;
using UnityEngine.U2D;

/**
 * 
 */
public class SpriteManager : Singleton<SpriteManager>
{
    public SpriteAtlas atlas; //

    /**
	 * 
	 */
    public Sprite Get(string k)
    {
        var em = new GameObjectMetaData(k);

        Sprite sprite;

        if (sprite = atlas.GetSprite(em.slug + "." + em.type + "_" + em.variation)) { return sprite; } //Can replace this chain with a bunch of OR statements.
        if (sprite = atlas.GetSprite(em.slug + "_" + em.variation)) { return sprite; }
        if (sprite = atlas.GetSprite(em.slug + "." + em.type)) { return sprite; }
        if (sprite = atlas.GetSprite(em.slug)) { return sprite; }

        return atlas.GetSprite("untitled");
    }
}
