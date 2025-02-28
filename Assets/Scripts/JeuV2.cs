using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JeuV2 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _etiquettePoints;
    [SerializeField] private TextMeshProUGUI _temps;

    public int pointsJeu = 0;
    public int tempsJeu = 0;

    void Start()
    {
        pointsJeu = 0;
        tempsJeu = 0;
        InvokeRepeating ("AugmenterTemps", 1f, 1f);
    }

    public void AugmenterPoints()
    {
        // Augmenter les points du jeu
        pointsJeu++;
        // Actualiser l'UI
        _etiquettePoints.text = "$" + pointsJeu.ToString();
    }

    public void AugmenterTemps()
    {
        
        tempsJeu++;
        _temps.text =  tempsJeu.ToString() + " s ";
    }
}
