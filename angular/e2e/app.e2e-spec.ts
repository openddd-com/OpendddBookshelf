import { OpendddTemplatePage } from './app.po';

describe('abp-project-name-template App', function() {
  let page: OpendddTemplatePage;

  beforeEach(() => {
    page = new OpendddTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
