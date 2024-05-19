package Base;

import org.openqa.selenium.*;

public class PageGenerator {
    WebDriver driver;
    boolean basarili = false;
    JavascriptExecutor js = (JavascriptExecutor) driver;

    public By teslimatNoktasi=By.xpath("//span[@class='a-truncate-cut'][contains(text(),'Hemen keşfet')]");

    public By cerezleriKabulEyle=By.xpath("//input[@name='accept']");

    public By adresBul=By.xpath("//input[@class='_1Y1XJws5SacZ4d2QV3kB2w']");
    public By adresBulClik=By.xpath(" //i[@class='a-icon a-icon-search']");

    public By adresBulicClik=By.xpath("/html/body/div[1]/div[1]/div[3]/div[2]/div/div/div/div/div[2]/div[1]/div/div[2]/div/ul/li[1]");

    public By adresDefteriEkle=By.xpath("/html[1]/body[1]/div[1]/div[1]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/span[1]/span[1]/input[1]");
    public By mail=By.xpath("//input[@id='ap_email']");

    public By sifre=By.xpath("//input[@id='ap_password']");

    public By girisBut=By.xpath("//input[@id='signInSubmit']");

public By dogrulama=By.xpath("//span[contains(text(),'Teslim Alma Noktası eklendi. Ödeme adımında adresl')]");
    public PageGenerator(WebDriver driver) {
        this.driver=driver;
    }
    public void cerezler() throws InterruptedException {
        Thread.sleep(5000);
        driver.findElement(cerezleriKabulEyle).click();
        Thread.sleep(2000);
    }
    public void teslimatNoktasinaGit() throws InterruptedException {
        driver.findElement(teslimatNoktasi).click();
        Thread.sleep(4000);
    }


        public void adresBulma() throws InterruptedException {
            driver.findElement(adresBul).sendKeys("tuzla sokak");
            Thread.sleep(4000);
            driver.findElement(adresBulClik).click();
            Thread.sleep(3000);
            driver.findElement(adresBulicClik).click();
            Thread.sleep(3000);
        }

    public void adresDefteri() throws InterruptedException {
        driver.findElement(adresDefteriEkle).sendKeys("tuzla sokak");
        Thread.sleep(4000);
    }

    public void giris() throws  InterruptedException{
    driver.findElement(mail).sendKeys("yusufyasararis@gmail.com");
    Thread.sleep(2000);
    driver.findElement(sifre).sendKeys("278089000");
    Thread.sleep(2000);
    driver.findElement(girisBut).click();
        Thread.sleep(5000);
    }
    public void onaylama() throws InterruptedException {
        try {

            WebElement sonucSayisiElementi = driver.findElement(By.xpath("//div[@class=\"a-alert-content\"]"));

            System.out.println(sonucSayisiElementi.findElements(By.tagName("div")).size());
            // Eğer arama sonuçları varsa, başarılı sayılır
            if (sonucSayisiElementi.findElements(By.tagName("div")).size() > 0) {
                basarili = true;
                js.executeScript("alert('ekleme basarili')");
            } else {
                js.executeScript("alert('ekleme basarisiz')");
            }
            Thread.sleep(2000);
            Alert alert = driver.switchTo().alert();
            alert.accept();

        } catch (Exception e) {

        }

    }
}

