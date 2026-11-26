using UnityEngine;
using UnityEngine.UI;

public class Drawer : MonoBehaviour
{
    [SerializeField] private Sprite leftSprite;
    [SerializeField] private Sprite rightSprite;
    [SerializeField] private Sprite bothSprite;

    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();
    }
    public void OpenLeftDrawer()
    { 
        if (image.sprite == rightSprite)
        {
            image.sprite = bothSprite;
        } 
        else
        {
            image.sprite = leftSprite;
        }

    } 
    public void OpenRightDrawer()
    {
        if (image.sprite == leftSprite)
        {
            image.sprite = bothSprite;
        } 
        else
        {
            image.sprite = rightSprite;
        }
      
    }


}
