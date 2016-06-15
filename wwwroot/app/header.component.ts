import { Component } from 'angular2/core';

@Component({
    selector: 'header-content',
    templateUrl: 'app/header.html'
})

export class HeaderComponent {
    page_title = 'Simple todo app - Angular2'
}