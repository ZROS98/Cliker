using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Threading;
using UnityEngine.Serialization;

public class Game : MonoBehaviour {
    public Text scoreText, duckPriceText, bonusText1,bonusText2,bonusText3,bonusText4,bonusText5,bonusText6,bonusText7,bonusText8;
    public Text plusText11, plusText12, plusText13, plusText21, plusText22, plusText23, plusText31, plusText32,plusText33;
    public Text plusText41, plusText42, plusText43, plusText51, plusText52, plusText53, plusText61, plusText62,plusText63;
    public Text plusText71, plusText72, plusText73, plusText81, plusText82, plusText83;
    public GameObject circle1, circle2, circle3, circle4, circle5, circle6, circle7, circle8,finalBG;
    public GameObject evolve1,evolve2,evolve3,evolve4,evolve5,evolve6,evolve7,evolve8;
    public double score = 5;
    public GameObject bird1,bird2,bird3,bigBird1,bigBird2,bigBird3,finalBird1,finalBird2,finalBird3;
    public GameObject dog1, dog2, dog3, wolf1, wolf2, wolf3, cerber1, cerber2, cerber3;
    public GameObject egg1, egg2, egg3, dragon1, dragon2, dragon3, boss, final;
    public Button bonusB1, bonusB2, bonusB3, bonusB4, bonusB5, bonusB6, bonusB7, bonusB8;
    public GameObject buttonHoler1,buttonHoler2,buttonHoler3,buttonHoler4,buttonHoler5,buttonHoler6,buttonHoler7,buttonHoler8;
    public double maxBirdCount = 0;
    public double maxBigBirdCount = 0;
    public double maxFinalBirdCount = 0;
    public double maxDogCount=0, maxWolfCount=0, maxCerberCount=0;
    public double maxEggCount=0, maxDragonCount=0;
    public double birdPrice = 5;
    public double upgradePriceLvl = 1.1;
    public double bonusPrice1, bonusPrice2,bonusPrice3,bonusPrice4,bonusPrice5,bonusPrice6,bonusPrice7,bonusPrice8;
    public int bonusTime=10;
    

   
    
    
    

    public void Start() {
        
        StartCoroutine(BonusPerOneBird());
        StartCoroutine(BonusPerOneBigBird());
        StartCoroutine(BonusPerOneFinalBird());
        StartCoroutine(BonusPerOneDog());
        StartCoroutine(BonusPerOneWolf());
        StartCoroutine(BonusPerOneCerber());
        StartCoroutine(BonusPerOneEgg());
        StartCoroutine(BonusPerOneDragon());
        
    }

    public void OnClick() { 
        score++;
    }
    public void OnBigBirdClick() {
        score += 3;
    }

    public void OnFinalBirdClick() {
        score += 9;
    }

    public void OnDogClick() {
        score += 27;
    }

    public void OnWolfClick() {
        score += 81;
    }

    public void OnCerberClick() {
        score += 243;
    }

    public void OnEggClick() {
        score += 729;
    }

    public void OnDragonClick() {
        score += 2187;
    }

    public void OnBossClick() {
        final.SetActive(true);
    }


    private void Update() {

        int birdPrice = Convert.ToInt32(this.birdPrice);
        int score = Convert.ToInt32(this.score);
        int bonusPrice1 = Convert.ToInt32(this.bonusPrice1);
        int bonusPrice2 = Convert.ToInt32(this.bonusPrice2);
        int bonusPrice3 = Convert.ToInt32(this.bonusPrice3);
        int bonusPrice4 = Convert.ToInt32(this.bonusPrice4);
        int bonusPrice5 = Convert.ToInt32(this.bonusPrice5);
        int bonusPrice6 = Convert.ToInt32(this.bonusPrice6);
        int bonusPrice7 = Convert.ToInt32(this.bonusPrice7);
        int bonusPrice8 = Convert.ToInt32(this.bonusPrice8);

        duckPriceText.text = "Bird:" + birdPrice + " É";
        scoreText.text = "Evolution points:\n" + score + " É";
        bonusText1.text = "Bird boost for 10s:" + bonusPrice1 + "É";
        bonusText2.text = "Big bird boost for 10s:" + bonusPrice2 + "É";
        bonusText3.text = "Final bird boost for 10s:" + bonusPrice3 + "É";
        bonusText4.text = "Dog boost for 10s:" + bonusPrice4 + "É";
        bonusText5.text = "Wolf boost for 10s:" + bonusPrice5 + "É";
        bonusText6.text = "cerberus boost for 10s:" + bonusPrice6 + "É";
        bonusText7.text = "Egg boost for 10s:" + bonusPrice7 + "É";
        bonusText8.text = "Dragon boost for 10s:" + bonusPrice8 + "É";
        if (maxBirdCount==3 && maxBigBirdCount!=3) {
            evolve1.SetActive(true);
        }
        else evolve1.SetActive(false);

        if (maxBigBirdCount == 3 && maxFinalBirdCount!=3) {
            evolve2.SetActive(true);
        }
        else evolve2.SetActive(false);
        
        if (maxFinalBirdCount == 3 && maxDogCount!=3) {
            evolve3.SetActive(true);
        }
        else evolve3.SetActive(false);
        
        if (maxDogCount == 3 && maxWolfCount!=3) {
            evolve4.SetActive(true);
        }
        else evolve4.SetActive(false);
        
        if (maxWolfCount == 3 && maxCerberCount!=3) {
            evolve5.SetActive(true);
        }
        else evolve5.SetActive(false);
        
        if (maxCerberCount == 3 && maxEggCount!=3) {
            evolve6.SetActive(true);
        }
        else evolve6.SetActive(false);
        
        if (maxEggCount == 3 && maxDragonCount!=3) {
            evolve7.SetActive(true);
        }
        else evolve7.SetActive(false);
        
        if (maxDragonCount == 3) {
            evolve8.SetActive(true);
        }
        else evolve8.SetActive(false);

        if (score >= 50) {
            buttonHoler1.SetActive(false);
            bonusB1.image.enabled = true;
            bonusText1.enabled = true;
        }

        if (maxBirdCount == 0||bonusPrice1>score) {
           buttonHoler1.SetActive(true);
        }else
            buttonHoler1.SetActive(false);
        

        if (maxBigBirdCount > 0) {
            buttonHoler2.SetActive(false);
            bonusB2.image.enabled = true;
            bonusText2.enabled = true;
        }

        if (maxBigBirdCount == 0||bonusPrice2>score) {
           buttonHoler2.SetActive(true);
        }
        else 
            buttonHoler2.SetActive(false);
        
        
        if (maxFinalBirdCount > 0) {
            buttonHoler3.SetActive(false);
            bonusB3.image.enabled = true;
            bonusText3.enabled = true;
        }

        if (maxFinalBirdCount == 0||bonusPrice3>score) {
            buttonHoler3.SetActive(true);
        }
        else {
            buttonHoler3.SetActive(false);
        }
        
        if (maxDogCount > 0) {
            buttonHoler4.SetActive(false);
            bonusB4.image.enabled = true;
            bonusText4.enabled = true;
        }

        if (maxDogCount == 0||bonusPrice4>score) {
            buttonHoler4.SetActive(true);
        }
        else {
            buttonHoler4.SetActive(false);
        }
        
        if (maxWolfCount > 0) {
            buttonHoler5.SetActive(false);
            bonusB5.image.enabled = true;
            bonusText5.enabled = true;
        }

        if (maxWolfCount == 0||bonusPrice5>score) {
            buttonHoler5.SetActive(true);
        }
        else {
            buttonHoler5.SetActive(false);
        }
        
        if (maxCerberCount > 0) {
            buttonHoler6.SetActive(false);
            bonusB6.image.enabled = true;
            bonusText6.enabled = true;
        }

        if (maxCerberCount == 0||bonusPrice6>score) {
            buttonHoler6.SetActive(true);
        }
        else {
            buttonHoler6.SetActive(false);
        }
        
        if (maxEggCount > 0) {
            buttonHoler7.SetActive(false);
            bonusB7.image.enabled = true;
            bonusText7.enabled = true;
        }

        if (maxEggCount == 0||bonusPrice7>score) {
            buttonHoler7.SetActive(true);
        }
        else {
            buttonHoler7.SetActive(false);
        }
        
        if (maxDragonCount > 0) {
            buttonHoler8.SetActive(false);
            bonusB8.image.enabled = true;
            bonusText8.enabled = true;
        }

        if (maxDragonCount == 0||bonusPrice8>score) {
            buttonHoler8.SetActive(true);
        }
        else {
            buttonHoler8.SetActive(false);
        }
        
    }

    public void DuckShop() {
        
        if (score >= birdPrice && maxBirdCount == 0 ) {
            score -= birdPrice;
            bird1.SetActive(true);
            
            maxBirdCount = +1;            
            birdPrice *= upgradePriceLvl;
        }else if (score >= birdPrice && maxBirdCount == 1) {
            score -= birdPrice;
            bird2.SetActive(true);
            
            maxBirdCount = +2;
            birdPrice *= upgradePriceLvl;
        } else if (score >= birdPrice && maxBirdCount == 2) {
            score -= birdPrice;
            bird3.SetActive(true);
            
            maxBirdCount = +3;
            birdPrice *= upgradePriceLvl;
        }
    }

   

    public void Bonus1() {
        StartCoroutine(BonusCounter1());
    }
    public void Bonus2() {
        StartCoroutine(BonusCounter2());
    }
    public void Bonus3() {
        StartCoroutine(BonusCounter3());
    }
    public void Bonus4() {
        StartCoroutine(BonusCounter4());
    }
    public void Bonus5() {
        StartCoroutine(BonusCounter5());
    }
    public void Bonus6() {
        StartCoroutine(BonusCounter6());
    }
    public void Bonus7() {
        StartCoroutine(BonusCounter7());
    }
    public void Bonus8() {
        StartCoroutine(BonusCounter8());
    }

    IEnumerator BonusCounter1() {
        bonusPrice1 = birdPrice * 5;
        if (score >= bonusPrice1 && maxBirdCount>0) {
            bonusB1.enabled = false;
            yield return new WaitForSeconds(bonusTime);
            bonusB1.enabled = true;
            score= score - bonusPrice1;
        }
    }
    
    IEnumerator BonusCounter2() {
        bonusPrice2 = birdPrice * 10;
        if (score >= bonusPrice2 && maxBigBirdCount>0) {
            score= score - bonusPrice2;
            bonusB2.enabled = false;
            yield return new WaitForSeconds(bonusTime);
            bonusB2.enabled = true;
        }
    }
    
    IEnumerator BonusCounter3() {
        bonusPrice3 = birdPrice * 15;
        if (score >= bonusPrice3 && maxFinalBirdCount>0) {
            score= score - bonusPrice3;
            bonusB3.enabled = false;
            yield return new WaitForSeconds(bonusTime);
            bonusB3.enabled = true;
        }
    }
    
    IEnumerator BonusCounter4() {
        bonusPrice4 = birdPrice * 20;
        if (score >= bonusPrice4 && maxDogCount>0) {
            score= score - bonusPrice4;
            bonusB4.enabled = false;
            yield return new WaitForSeconds(bonusTime);
            bonusB4.enabled = true;
        }
    }
    
    IEnumerator BonusCounter5() {
        bonusPrice5 = birdPrice * 25;
        if (score >= bonusPrice5 && maxWolfCount>0) {
            score= score - bonusPrice5;
            bonusB5.enabled = false;
            yield return new WaitForSeconds(bonusTime);
            bonusB5.enabled = true;
        }
    }
    
    IEnumerator BonusCounter6() {
        bonusPrice6 = birdPrice * 30;
        if (score >= bonusPrice6 && maxCerberCount>0) {
            score= score - bonusPrice6;
            bonusB6.enabled = false;
            yield return new WaitForSeconds(bonusTime);
            bonusB6.enabled = true;
        }
    }
    
    IEnumerator BonusCounter7() {
        bonusPrice7 = birdPrice * 35;
        if (score >= bonusPrice7 && maxEggCount>0) {
            score= score - bonusPrice7;
            bonusB7.enabled = false;
            yield return new WaitForSeconds(bonusTime);
            bonusB7.enabled = true;
        }
    }
    
    IEnumerator BonusCounter8() {
        bonusPrice8 = birdPrice * 40;
        if (score >= bonusPrice8 && maxDragonCount>0) {
            score= score - bonusPrice8;
            bonusB8.enabled = false;
            yield return new WaitForSeconds(bonusTime);
            bonusB8.enabled = true;
        }
    }
    
    IEnumerator BonusPerOneBird() {
        while (true) {
            bonusPrice1 = birdPrice * 5;
            if (bonusB1.enabled == false) {
                score += (maxBirdCount * 5);
                plusText11.text = " 5É";
                plusText12.text = " 5É";
                plusText13.text = " 5É";
            }
            else {
                score += maxBirdCount;
                plusText11.text = " 1É";
                plusText12.text = " 1É";
                plusText13.text = " 1É";
            }

            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator BonusPerOneBigBird() {
        while (true) {
            bonusPrice2 = birdPrice * 10;
            if (bonusB2.enabled == false) {
                score += (maxBigBirdCount * 15);
                plusText21.text = " 15É";
                plusText22.text = " 15É";
                plusText23.text = " 15É";
            }
            else {
                score += (maxBigBirdCount * 3);
                plusText21.text = " 3É";
                plusText22.text = " 3É";
                plusText23.text = " 3É";
            }

            yield return new WaitForSeconds(1);
            
        }
    }


    

    IEnumerator BonusPerOneFinalBird() {
        while (true) {
            bonusPrice3 = birdPrice * 15;
            if (bonusB3.enabled == false) {
                score += (maxFinalBirdCount * 45);
                plusText31.text = " 45É";
                plusText32.text = " 45É";
                plusText33.text = " 45É";
            }
            else {
                score += (maxFinalBirdCount * 9);
                plusText31.text = " 9É";
                plusText32.text = " 9É";
                plusText33.text = " 9É";
            }
            yield return  new WaitForSeconds(1);
        }
    }
    IEnumerator BonusPerOneDog() {
        while (true) {
            bonusPrice4 = birdPrice * 20;
            if (bonusB4.enabled == false) {
                score += (maxDogCount * 135);
                plusText41.text = " 135É";
                plusText42.text = " 135É";
                plusText43.text = " 135É";
            }
            else {
                score += (maxDogCount * 27);
                plusText41.text = " 27É";
                plusText42.text = " 27É";
                plusText43.text = " 27É";
            }

            yield return  new WaitForSeconds(1);
        }
    }
    IEnumerator BonusPerOneWolf() {
        while (true) {
            bonusPrice5 = birdPrice * 25;
            if (bonusB5.enabled == false) {
                score += (maxWolfCount * 405);
                plusText51.text = " 405É";
                plusText52.text = " 405É";
                plusText53.text = " 405É";
            }
            else {
                score += (maxWolfCount * 81);
                plusText51.text = " 81É";
                plusText52.text = " 81É";
                plusText53.text = " 81É";
            }

            yield return  new WaitForSeconds(1);
        }
    }
    IEnumerator BonusPerOneCerber() {
        while (true) {
            bonusPrice6 = birdPrice * 30;
            if (bonusB6.enabled == false) {
                score += (maxCerberCount * 1215);
                plusText61.text = " 1215É";
                plusText62.text = " 1215É";
                plusText63.text = " 1215É";
            }
            else {
                score += (maxCerberCount * 243);
                plusText61.text = " 243É";
                plusText62.text = " 243É";
                plusText63.text = " 243É";
            }

            yield return  new WaitForSeconds(1);
        }
    }
    IEnumerator BonusPerOneEgg() {
        while (true) {
            bonusPrice7 = birdPrice * 35;
            if (bonusB7.enabled == false) {
                score += (maxEggCount * 3645);
                plusText71.text = " 3645É";
                plusText72.text = " 3645É";
                plusText73.text = " 3645É";
            }
            else {
                score += (maxEggCount * 729);
                plusText71.text = " 729É";
                plusText72.text = " 729É";
                plusText73.text = " 729É";
            }

            yield return  new WaitForSeconds(1);
        }
    }
    IEnumerator BonusPerOneDragon() {
        while (true) {
            bonusPrice8 = birdPrice * 40;
            if (bonusB8.enabled == false) {
                score += (maxDragonCount * 10935);
                plusText81.text = " 10935É";
                plusText82.text = " 10935É";
                plusText83.text = " 10935É";
            }
            else {
                score += (maxDragonCount * 2187);
                plusText81.text = " 2187É";
                plusText82.text = " 2187É";
                plusText83.text = " 2187É";
            }

            yield return  new WaitForSeconds(1);
        }
    }

    IEnumerator Circle1On() {
        circle1.SetActive(true);
        yield return new WaitForSeconds(1f);
        circle1.SetActive(false);
        bird1.SetActive(false);
        bird2.SetActive(false);
        bird3.SetActive(false);
        
        maxBirdCount = 0;
        if (maxBigBirdCount == 0) {
            bigBird1.SetActive(true);
            
            maxBigBirdCount = 1;
        } else if (maxBigBirdCount == 1) {
            bigBird2.SetActive(true);
            
            maxBigBirdCount = 2;
        }else if (maxBigBirdCount == 2){
            bigBird3.SetActive(true);
           
            maxBigBirdCount = 3;
        }
    }

    public void Evolve1() {
        StartCoroutine(Circle1On());
    }
    
    public void Evolve2() {
        StartCoroutine(Circle2On());
    }
    
    public void Evolve3() {
        StartCoroutine(Circle3On());
    }
    
    public void Evolve4() {
        StartCoroutine(Circle4On());
    }
    
    public void Evolve5() {
        StartCoroutine(Circle5On());
    }
    
    public void Evolve6() {
        StartCoroutine(Circle6On());
    }
    public void Evolve7() {
        StartCoroutine(Circle7On());
    }

    public void Evolve8() {
        StartCoroutine(Circle8On());
    }

    IEnumerator Circle2On() {
        circle2.SetActive(true);
        yield return new WaitForSeconds(1f);
        circle2.SetActive(false);
        
        bigBird1.SetActive(false);
        bigBird2.SetActive(false);
        bigBird3.SetActive(false);
        maxBigBirdCount = 0;
        if (maxFinalBirdCount == 0) {
            finalBird1.SetActive(true);
            
            maxFinalBirdCount = 1;
        } else if (maxFinalBirdCount == 1) {
            finalBird2.SetActive(true);
            
            maxFinalBirdCount = 2;
        }else if (maxFinalBirdCount == 2){
            finalBird3.SetActive(true);
            
            maxFinalBirdCount = 3;
        }
    }
    IEnumerator Circle3On() {
        circle3.SetActive(true);
        yield return new WaitForSeconds(1f);
        circle3.SetActive(false);
        finalBird1.SetActive(false);
        finalBird2.SetActive(false);
        finalBird3.SetActive(false);
        maxFinalBirdCount = 0;
        if (maxDogCount == 0) {
            dog1.SetActive(true);
            
            maxDogCount = 1;
        } else if (maxDogCount == 1) {
            dog2.SetActive(true);
            
            maxDogCount = 2;
        }else if (maxDogCount == 2){
            dog3.SetActive(true);
            
            maxDogCount = 3;
        }
    }
    IEnumerator Circle4On() {
        circle4.SetActive(true);
        yield return new WaitForSeconds(1f);
        circle4.SetActive(false);
        dog1.SetActive(false);
        dog2.SetActive(false);
        dog3.SetActive(false);
        maxDogCount = 0;
        if (maxWolfCount == 0) {
            wolf1.SetActive(true);
            
            maxWolfCount = 1;
        } else if (maxWolfCount == 1) {
            wolf2.SetActive(true);
            
            maxWolfCount = 2;
        }else if (maxWolfCount == 2){
            wolf3.SetActive(true);
            
            maxWolfCount = 3;
        }
    }
    IEnumerator Circle5On() {
        circle5.SetActive(true);
        yield return new WaitForSeconds(1f);
        circle5.SetActive(false);
        wolf1.SetActive(false);
        wolf2.SetActive(false);
        wolf3.SetActive(false);
        maxWolfCount = 0;
        if (maxCerberCount == 0) {
            cerber1.SetActive(true);
           
            maxCerberCount = 1;
        } else if (maxCerberCount == 1) {
            cerber2.SetActive(true);
           
            maxCerberCount = 2;
        }else if (maxCerberCount == 2){
            cerber3.SetActive(true);
            
            maxCerberCount = 3;
        }
    }
    IEnumerator Circle6On() {
        circle6.SetActive(true);
        yield return new WaitForSeconds(1f);
        circle6.SetActive(false);
        cerber1.SetActive(false);
        cerber2.SetActive(false);
        cerber3.SetActive(false);
        maxCerberCount = 0;
        if (maxEggCount == 0) {
            egg1.SetActive(true);
            maxEggCount = 1;
        } else if (maxEggCount == 1) {
            egg2.SetActive(true);
            
            maxEggCount = 2;
        }else if (maxEggCount == 2){
            egg3.SetActive(true);
            
            maxEggCount = 3;
        }
    }
    IEnumerator Circle7On() {
        circle7.SetActive(true);
        yield return new WaitForSeconds(1f);
        circle7.SetActive(false);
        egg1.SetActive(false);
        egg2.SetActive(false);
        egg3.SetActive(false);
        maxEggCount= 0;
        if (maxDragonCount == 0) {
            dragon1.SetActive(true);
            
            maxDragonCount = 1;
        } else if (maxDragonCount == 1) {
            dragon2.SetActive(true);
            
            maxDragonCount = 2;
        }else if (maxDragonCount == 2){
            dragon3.SetActive(true);
            
            maxDragonCount = 3;
        }
    }
    IEnumerator Circle8On() {
        finalBG.SetActive(true);
        
        yield return new WaitForSeconds(1f);
        circle8.SetActive(true);
        yield return new WaitForSeconds(3.1f);
        boss.SetActive(true);
        
    }

   







}




