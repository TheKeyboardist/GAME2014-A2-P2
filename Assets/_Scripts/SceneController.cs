/***;
*Project            : Traffic Jumper 
*
*Program name       : "SceneController.cs"
*
* Author            : Ivan Kravchenko
* 
* Student Number    : 101183016
*
*Date created       : 15/12/20
*
*Description        : opens gameplay scene
*
*Last modified      : 15/12/20
*
* Revision History  :
*
*Date        Author Ref    Revision (Date in YYYYMMDD format) 
*15/12/20    Ivan Kravchenko        Created script. 
*
|**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{


    public void OnButtonPressed()
    {
        SceneManager.LoadScene("Platformer");
    }
}
