package Base;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;

public class PageGenerator {
    WebDriver driver;
    public By arama=By.xpath("//input[@id='twotabsearchtextbox']");
    public By aramaButton=By.xpath("//input[@id='nav-search-submit-button']");

    public By cerezleriKabulEyle=By.xpath("//input[@name='accept']");

    public By markaSec=By.xpath("//span[@class='a-size-base a-color-base'][normalize-space()='Kyraton']");

    public By siralamOlcusuClick=By.xpath("//span[@class='a-dropdown-prompt']");

    public By musteriYorumu=By.xpath("//a[@id='s-result-sort-select_4']");

    //a[@id='s-result-sort-select_4']

    public PageGenerator(WebDriver driver) {this.driver=driver;}
    public void cerezler() throws InterruptedException {
        Thread.sleep(5000);
        driver.findElement(cerezleriKabulEyle).click();
        Thread.sleep(2000);
    }
    public void aramayaz() throws InterruptedException {
        driver.findElement(arama).click();
        Thread.sleep(1000);
        driver.findElement(arama).sendKeys("mutfak");
        Thread.sleep(2000);
        driver.findElement(aramaButton).click();
        Thread.sleep(6000);
    }

    public void markaSecimi() throws InterruptedException{
        driver.findElement(markaSec).click();
        Thread.sleep(2000);
    }
    public void sirlamaOlcusu()throws InterruptedException{
        driver.findElement(siralamOlcusuClick).click();
        Thread.sleep(2000);
        driver.findElement(musteriYorumu).click();
        Thread.sleep(2000);
    }


}
