import { browser, by, element } from 'protractor';

export class AppPage {

  private credentias = {
    login: 'admin',
    password: 'admin'
  };

  navigateTo() {
    return browser.get('/login');
  }

  fillCredentials(credentias: any = this.credentias){

    element(by.id('username')).sendKeys(credentias.login);
    element(by.id('pass')).sendKeys(credentias.password);
  
    element(by.id('buttonlogin')).click();
    
  }

  getPageTitleText(){
    return element(by.css('h3')).getText();
    
  }

  getErrorMessage(){
    return element(by.css('.alert-danger')).getText();
  }
}
