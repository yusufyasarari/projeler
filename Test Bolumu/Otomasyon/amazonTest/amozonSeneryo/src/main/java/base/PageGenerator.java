package base;

import org.openqa.selenium.*;
import org.openqa.selenium.interactions.Actions;
import org.openqa.selenium.support.FindBy;

public class PageGenerator {
    WebDriver driver;

    JavascriptExecutor js;

    boolean basarili = false;

    public By arama=By.xpath("//input[@id='twotabsearchtextbox']");


    public By aramaButton=By.xpath("//input[@id='nav-search-submit-button']");

    public By urruneGit=By.xpath("//span[@class='a-size-base-plus a-color-base a-text-normal'][contains(text(),'Rs775 24V 12000 Rpm Dc Motor Hobi Matkap, Cnc, Tes')]");
    public By sepetekleButton=By.xpath("//input[@id='add-to-cart-button']");


    public By sepeteGitButton=By.xpath("//a[normalize-space()='Sepete Git']");
  //  @FindBy(xpath = " //input[@id='sp-cc-accept']")
    public By cerezleriKabulEyle=By.xpath("//input[@name='accept']");

    public PageGenerator(WebDriver driver) {
        this.driver=driver;
    }
    public void cerezler() throws InterruptedException {
        Thread.sleep(5000);
        driver.findElement(cerezleriKabulEyle).click();
        Thread.sleep(2000);
    }
    public void aramayaz() throws InterruptedException {
        driver.findElement(arama).click();
        Thread.sleep(1000);
        driver.findElement(arama).sendKeys("motor");
        Thread.sleep(2000);
        driver.findElement(aramaButton).click();
        Thread.sleep(6000);
    }

    public void uruneGit() throws InterruptedException {
        driver.findElement(urruneGit).click();
        Thread.sleep(4000);
    }

    public void sepeteEkle() throws InterruptedException {
        driver.findElement(sepetekleButton).click();
        Thread.sleep(6000);
    }

    public void sepeteGit() throws InterruptedException {
        driver.findElement(sepeteGitButton).click();
        Thread.sleep(5000);
    }

    public void sepetKontrol() throws InterruptedException {
        try {
            WebElement sonucSayisiElementi = driver.findElement(By.xpath("//div[@data-name=\"Active Items\"]"));
            System.out.println(sonucSayisiElementi.findElements(By.tagName("p")).size());
            // Eğer arama sonuçları varsa, başarılı sayılır
            if (sonucSayisiElementi.findElements(By.tagName("p")).size()>0) {
                basarili = true;
                js.executeScript("alert('urun bulundu')");
            } else {
                js.executeScript("alert('urun bulunamadi')");
            }
            Thread.sleep(2000);
            Alert alert = driver.switchTo().alert();
            alert.accept();
        } catch (Exception e) {

        }
        Thread.sleep(6000);
    }
}
