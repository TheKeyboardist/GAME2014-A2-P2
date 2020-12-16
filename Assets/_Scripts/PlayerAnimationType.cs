/***;
*Project            : Traffic Jumper 
*
*Program name       : "PlayreAnimationType.cs"
*
* Author            : Ivan Kravchenko
* 
* Student Number    : 101183016
*
*Date created       : 15/12/20
*
*Description        : oenum for animations
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

[System.Serializable]
public enum PlayerAnimationType 
{
    IDLE,
    RUN,
    JUMP,
    CROUCH
}
