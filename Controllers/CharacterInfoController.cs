using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInfoController
{
    private CharacterInfoPanel _view;
    private EntityStats _model;

    public CharacterInfoController(CharacterInfoPanel view, EntityStats model)
    {
        _model = model;
        _view = view;
        view.Init(_model);

    }
}
