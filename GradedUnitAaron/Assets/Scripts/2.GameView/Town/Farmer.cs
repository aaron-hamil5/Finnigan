using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmer : BuildingBase
{
    #region Variables
    #region Comment
    /*
        Comments that are multiline should
        be around this length before starting
        a new line.
     */
    #endregion

    private bool run;
    private bool doOnce;

    #endregion

    #region Unity Triggers
    void Start()
    {
        #region Comment
        /*
            Comments that are multiline should
            be around this length before starting
            a new line.
         */
        #endregion
        UI = FindObjectOfType<UIUpdater>();
    }

    void Update()
    {
        #region Comment
        /*
            Comments that are multiline should
            be around this length before starting
            a new line.
         */
        #endregion
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player") && !doOnce)
        {
            if (!Tasks.LearnAboutCES)
            {
                switch (TownLogic.roundCount)
                {
                    case 0:
                        RequirementsCheck(30, 10, 20, 5, 2, IncreaseNext, "Miners");
                        break;
                    case 1:
                        RequirementsCheck(60, 25, 10, 10, 2, IncreaseNext, "Miners");
                        break;
                    case 2:
                        RequirementsCheck(65, 30, 20, 20, 2, IncreaseNext, "Miners");
                        break;

                }
            }
            else if (Tasks.LearnAboutCES)
            {
                Debug.Log("IM HERE!");
                RequirementsCheck( 25,30,15,40,2,IncreaseNext, "Miners");
            }
            doOnce = true;
        }
    }
    #endregion

    #region Methods

    #region Miners Increase 
    #region Comment
    /*
        Comments that are multiline should
        be around this length before starting
        a new line.
     */
    #endregion

    void IncreaseNext()
    {
        if (!Tasks.LearnAboutCES)
        {
            switch (TownLogic.roundCount)
            {
                case 0:
                    Miners.r1 = true;
                    break;
                case 1:
                    Miners.r2 = true;
                    break;
                case 2:
                    Miners.r3 = true;
                    break;
            }
        }else if (Tasks.LearnAboutCES)
        {
            Miners.CESEnabled = true;
        }
        
        doOnce = false;
    }

    #endregion

    #endregion
}

#region Script Log

#region Creation
/*
 * This file was created on
 * DATE:    Wed, 27 Apr
 * TIME:    15:03
 * BY:      Aaron Hamilton
 */
#endregion

#region Edit Logs
//Date: Thurs, 28 Apr 2022 | Time: 10:30 | Edit by: Aaron Hamilton
#endregion

#region Sources
/* Title:
 * By:
 * URL: 
 */
#endregion
#endregion

//Uniq Studio