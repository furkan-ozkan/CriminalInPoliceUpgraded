using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowParticle : MonoBehaviour
{
    public void ParticleShow(int particleNum,Vector3 position)
    {
        StartCoroutine(DeleteParticle(Instantiate(GetComponent<Particles>().particleList[particleNum],position,GetComponent<Particles>().particleList[particleNum].transform.rotation)));
    }
    IEnumerator DeleteParticle(GameObject particle)
    {
        yield return new WaitForSeconds(1f);
        Destroy(particle);
    }
}
