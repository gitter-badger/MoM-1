﻿/// <reference path="../../../typings/browser.d.ts" />
/// <reference path="../../../node_modules/zone.js/dist/zone.js.d.ts" />
/// <reference path="../../../node_modules/ng2-bootstrap/ng2-bootstrap.d.ts" />
import {bootstrap}    from "angular2/platform/browser"
import {ROUTER_PROVIDERS} from "angular2/router";
import {HTTP_PROVIDERS} from "angular2/http";
import {Ng2BootstrapConfig, Ng2BootstrapTheme} from 'ng2-bootstrap/ng2-bootstrap'; 

import {AppComponent} from "./app.component"

import {enableProdMode} from 'angular2/core';
Ng2BootstrapConfig.theme = Ng2BootstrapTheme.BS4;
enableProdMode();
bootstrap(AppComponent, [ROUTER_PROVIDERS, HTTP_PROVIDERS]);