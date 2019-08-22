import { AppPage } from './app.po';
import {browser,by,element,logging} from 'protractor';

describe('protractor-tutorial - Login page', () => {
  let page: AppPage;

  const wrongCredentias = {
    login: 'test',
    password: 'test'
  };

  beforeEach(() => {
    page = new AppPage();
  
  });

  function delay(ms: number) {
    return new Promise( resolve => setTimeout(resolve, ms) );
}
/*
it('when user trying to login with wrong credentials he should stay on “login” page and see error notification', () => {
  page.navigateTo();
  page.fillCredentials(wrongCredentias);
  expect(page.getPageTitleText()).toEqual('work-in-progress');
  expect(page.getErrorMessage()).toEqual('Username or password is incorrect');
});
*/

  it('when login is successful — he should redirect to default “public” page', async () => {
    page.navigateTo();
    page.fillCredentials();
    await delay(4000);
    expect(page.getPageTitleText()).toEqual('siamo bellissimi');
    expect(true).toBe(element(by.css('app-admin-dashboard')).isDisplayed());
  })
});