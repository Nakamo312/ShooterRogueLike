using System.Collections;
using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [SerializeField]
    private CharacterInfoController characterInfoController;

    [SerializeField]
    private PlayerInstance playerInstance;

    [SerializeField]
    private CharacterInfoPanel characterInfoPanel;

    private void Awake()
    {
        playerInstance = Instantiate(playerInstance);
        characterInfoPanel = Instantiate(characterInfoPanel);
        characterInfoController = new CharacterInfoController(characterInfoPanel,playerInstance.player.Stats);
    }
    void Start()
    {

    }

    void Update()
    {

    }

}