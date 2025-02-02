using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFootsteps : MonoBehaviour
{
    private enum CURRENT_TERRAIN { BLOCKS, STAIRS};
    [SerializeField]
    private CURRENT_TERRAIN currentTerrain;

    [SerializeField]
    private AK.Wwise.Event footstepsEvent;

    [SerializeField]
    private AK.Wwise.Switch[] terrainSwitch;

    private Rigidbody rb;
   // float timer = 0.0f;

   // [SerializeField]
   // float footstepSpeed = 0.3f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckTerrain();

        /*if(rb.velocity.magnitude > 1f && Mathf.Abs(rb.velocity.y) < 0.1f)
        {
            if (timer > footstepSpeed)
            {
                SelectAndPlayFootstep();
                timer = 0.0f;
            }

            timer += Time.deltaTime;
        } */
    }

    private void CheckTerrain()
    {
        RaycastHit[] hit;
        hit = Physics.RaycastAll(transform.position, Vector3.down, 10.0f);

        foreach (RaycastHit rayhit in hit)
        {
            if (rayhit.transform.gameObject.layer == LayerMask.NameToLayer("Blocks"))
            {
                currentTerrain = CURRENT_TERRAIN.BLOCKS;
            }
            else if (rayhit.transform.gameObject.layer == LayerMask.NameToLayer("Stairs"))
            {
                currentTerrain = CURRENT_TERRAIN.STAIRS;
            }
        }
    }

    private void PlayFootstep(int terrain)
    {
        terrainSwitch[terrain].SetValue(this.gameObject);
        AkSoundEngine.PostEvent(footstepsEvent.Id, this.gameObject);
    }
    public void SelectAndPlayFootstep()
    {

        switch (currentTerrain)
         {
             case CURRENT_TERRAIN.BLOCKS:
                 PlayFootstep(0);
                 break;

             case CURRENT_TERRAIN.STAIRS:
                 PlayFootstep(1);
                 break;
         }
    }
}
