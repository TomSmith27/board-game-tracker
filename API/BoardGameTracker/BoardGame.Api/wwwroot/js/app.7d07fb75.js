(function(e){function t(t){for(var r,i,o=t[0],c=t[1],l=t[2],d=0,m=[];d<o.length;d++)i=o[d],s[i]&&m.push(s[i][0]),s[i]=0;for(r in c)Object.prototype.hasOwnProperty.call(c,r)&&(e[r]=c[r]);u&&u(t);while(m.length)m.shift()();return n.push.apply(n,l||[]),a()}function a(){for(var e,t=0;t<n.length;t++){for(var a=n[t],r=!0,o=1;o<a.length;o++){var c=a[o];0!==s[c]&&(r=!1)}r&&(n.splice(t--,1),e=i(i.s=a[0]))}return e}var r={},s={app:0},n=[];function i(t){if(r[t])return r[t].exports;var a=r[t]={i:t,l:!1,exports:{}};return e[t].call(a.exports,a,a.exports,i),a.l=!0,a.exports}i.m=e,i.c=r,i.d=function(e,t,a){i.o(e,t)||Object.defineProperty(e,t,{enumerable:!0,get:a})},i.r=function(e){"undefined"!==typeof Symbol&&Symbol.toStringTag&&Object.defineProperty(e,Symbol.toStringTag,{value:"Module"}),Object.defineProperty(e,"__esModule",{value:!0})},i.t=function(e,t){if(1&t&&(e=i(e)),8&t)return e;if(4&t&&"object"===typeof e&&e&&e.__esModule)return e;var a=Object.create(null);if(i.r(a),Object.defineProperty(a,"default",{enumerable:!0,value:e}),2&t&&"string"!=typeof e)for(var r in e)i.d(a,r,function(t){return e[t]}.bind(null,r));return a},i.n=function(e){var t=e&&e.__esModule?function(){return e["default"]}:function(){return e};return i.d(t,"a",t),t},i.o=function(e,t){return Object.prototype.hasOwnProperty.call(e,t)},i.p="/";var o=window["webpackJsonp"]=window["webpackJsonp"]||[],c=o.push.bind(o);o.push=t,o=o.slice();for(var l=0;l<o.length;l++)t(o[l]);var u=c;n.push([0,"chunk-vendors"]),a()})({0:function(e,t,a){e.exports=a("cd49")},"05b0":function(e,t,a){},"0af1":function(e,t,a){},"129d":function(e,t,a){},"2f5e":function(e,t,a){"use strict";var r=a("7d76"),s=a.n(r);s.a},4678:function(e,t,a){var r={"./af":"2bfb","./af.js":"2bfb","./ar":"8e73","./ar-dz":"a356","./ar-dz.js":"a356","./ar-kw":"423e","./ar-kw.js":"423e","./ar-ly":"1cfd","./ar-ly.js":"1cfd","./ar-ma":"0a84","./ar-ma.js":"0a84","./ar-sa":"8230","./ar-sa.js":"8230","./ar-tn":"6d83","./ar-tn.js":"6d83","./ar.js":"8e73","./az":"485c","./az.js":"485c","./be":"1fc1","./be.js":"1fc1","./bg":"84aa","./bg.js":"84aa","./bm":"a7fa","./bm.js":"a7fa","./bn":"9043","./bn.js":"9043","./bo":"d26a","./bo.js":"d26a","./br":"6887","./br.js":"6887","./bs":"2554","./bs.js":"2554","./ca":"d716","./ca.js":"d716","./cs":"3c0d","./cs.js":"3c0d","./cv":"03ec","./cv.js":"03ec","./cy":"9797","./cy.js":"9797","./da":"0f14","./da.js":"0f14","./de":"b469","./de-at":"b3eb","./de-at.js":"b3eb","./de-ch":"bb71","./de-ch.js":"bb71","./de.js":"b469","./dv":"598a","./dv.js":"598a","./el":"8d47","./el.js":"8d47","./en-au":"0e6b","./en-au.js":"0e6b","./en-ca":"3886","./en-ca.js":"3886","./en-gb":"39a6","./en-gb.js":"39a6","./en-ie":"e1d3","./en-ie.js":"e1d3","./en-il":"7333","./en-il.js":"7333","./en-nz":"6f50","./en-nz.js":"6f50","./eo":"65db","./eo.js":"65db","./es":"898b","./es-do":"0a3c","./es-do.js":"0a3c","./es-us":"55c9","./es-us.js":"55c9","./es.js":"898b","./et":"ec18","./et.js":"ec18","./eu":"0ff2","./eu.js":"0ff2","./fa":"8df4","./fa.js":"8df4","./fi":"81e9","./fi.js":"81e9","./fo":"0721","./fo.js":"0721","./fr":"9f26","./fr-ca":"d9f8","./fr-ca.js":"d9f8","./fr-ch":"0e49","./fr-ch.js":"0e49","./fr.js":"9f26","./fy":"7118","./fy.js":"7118","./gd":"f6b4","./gd.js":"f6b4","./gl":"8840","./gl.js":"8840","./gom-latn":"0caa","./gom-latn.js":"0caa","./gu":"e0c5","./gu.js":"e0c5","./he":"c7aa","./he.js":"c7aa","./hi":"dc4d","./hi.js":"dc4d","./hr":"4ba9","./hr.js":"4ba9","./hu":"5b14","./hu.js":"5b14","./hy-am":"d6b6","./hy-am.js":"d6b6","./id":"5038","./id.js":"5038","./is":"0558","./is.js":"0558","./it":"6e98","./it.js":"6e98","./ja":"079e","./ja.js":"079e","./jv":"b540","./jv.js":"b540","./ka":"201b","./ka.js":"201b","./kk":"6d79","./kk.js":"6d79","./km":"e81d","./km.js":"e81d","./kn":"3e92","./kn.js":"3e92","./ko":"22f8","./ko.js":"22f8","./ky":"9609","./ky.js":"9609","./lb":"440c","./lb.js":"440c","./lo":"b29d","./lo.js":"b29d","./lt":"26f9","./lt.js":"26f9","./lv":"b97c","./lv.js":"b97c","./me":"293c","./me.js":"293c","./mi":"688b","./mi.js":"688b","./mk":"6909","./mk.js":"6909","./ml":"02fb","./ml.js":"02fb","./mn":"958b","./mn.js":"958b","./mr":"39bd","./mr.js":"39bd","./ms":"ebe4","./ms-my":"6403","./ms-my.js":"6403","./ms.js":"ebe4","./mt":"1b45","./mt.js":"1b45","./my":"8689","./my.js":"8689","./nb":"6ce3","./nb.js":"6ce3","./ne":"3a39","./ne.js":"3a39","./nl":"facd","./nl-be":"db29","./nl-be.js":"db29","./nl.js":"facd","./nn":"b84c","./nn.js":"b84c","./pa-in":"f3ff","./pa-in.js":"f3ff","./pl":"8d57","./pl.js":"8d57","./pt":"f260","./pt-br":"d2d4","./pt-br.js":"d2d4","./pt.js":"f260","./ro":"972c","./ro.js":"972c","./ru":"957c","./ru.js":"957c","./sd":"6784","./sd.js":"6784","./se":"ffff","./se.js":"ffff","./si":"eda5","./si.js":"eda5","./sk":"7be6","./sk.js":"7be6","./sl":"8155","./sl.js":"8155","./sq":"c8f3","./sq.js":"c8f3","./sr":"cf1e","./sr-cyrl":"13e9","./sr-cyrl.js":"13e9","./sr.js":"cf1e","./ss":"52bd","./ss.js":"52bd","./sv":"5fbd","./sv.js":"5fbd","./sw":"74dc","./sw.js":"74dc","./ta":"3de5","./ta.js":"3de5","./te":"5cbb","./te.js":"5cbb","./tet":"576c","./tet.js":"576c","./tg":"3b1b","./tg.js":"3b1b","./th":"10e8","./th.js":"10e8","./tl-ph":"0f38","./tl-ph.js":"0f38","./tlh":"cf75","./tlh.js":"cf75","./tr":"0e81","./tr.js":"0e81","./tzl":"cf51","./tzl.js":"cf51","./tzm":"c109","./tzm-latn":"b53d","./tzm-latn.js":"b53d","./tzm.js":"c109","./ug-cn":"6117","./ug-cn.js":"6117","./uk":"ada2","./uk.js":"ada2","./ur":"5294","./ur.js":"5294","./uz":"2e8c","./uz-latn":"010e","./uz-latn.js":"010e","./uz.js":"2e8c","./vi":"2921","./vi.js":"2921","./x-pseudo":"fd7e","./x-pseudo.js":"fd7e","./yo":"7f33","./yo.js":"7f33","./zh-cn":"5c3a","./zh-cn.js":"5c3a","./zh-hk":"49ab","./zh-hk.js":"49ab","./zh-tw":"90ea","./zh-tw.js":"90ea"};function s(e){var t=n(e);return a(t)}function n(e){var t=r[e];if(!(t+1)){var a=new Error("Cannot find module '"+e+"'");throw a.code="MODULE_NOT_FOUND",a}return t}s.keys=function(){return Object.keys(r)},s.resolve=n,e.exports=s,s.id="4678"},5972:function(e,t,a){"use strict";var r=a("129d"),s=a.n(r);s.a},"7d76":function(e,t,a){},"7faf":function(e,t,a){"use strict";var r=a("0af1"),s=a.n(r);s.a},"910e":function(e,t,a){},cd49:function(e,t,a){"use strict";a.r(t);a("cadf"),a("551c"),a("097d");var r=a("2b0e"),s=function(){var e=this,t=e.$createElement,a=e._self._c||t;return a("v-app",{attrs:{id:"inspire"}},[a("v-navigation-drawer",{attrs:{fixed:"",app:""},model:{value:e.drawer,callback:function(t){e.drawer=t},expression:"drawer"}},[a("v-list",{attrs:{dense:""}},[a("v-list-tile",{on:{click:function(e){}}},[a("v-list-tile-action",[a("v-icon",[e._v("home")])],1),a("v-list-tile-content",[a("router-link",{attrs:{to:{name:"home"}}},[e._v("Search")])],1)],1),a("v-list-tile",{on:{click:function(e){}}},[a("v-list-tile-action",[a("v-icon",[e._v("contact_mail")])],1),a("v-list-tile-content",[a("v-list-tile-title",[a("router-link",{attrs:{to:{name:"games"}}},[e._v("Games")])],1)],1)],1),a("v-list-tile",{on:{click:function(e){}}},[a("v-list-tile-action",[a("v-icon",[e._v("contact_mail")])],1),a("v-list-tile-content",[a("v-list-tile-title",[a("router-link",{attrs:{to:{name:"game-sessions"}}},[e._v("Game Sessions")])],1)],1)],1)],1)],1),a("v-toolbar",{attrs:{color:"primary",dark:"",fixed:"",app:""}},[a("v-toolbar-side-icon",{on:{click:function(t){t.stopPropagation(),e.drawer=!e.drawer}}}),a("v-toolbar-title",[e._v("Board Games")]),a("v-spacer"),a("v-menu",{attrs:{"offset-y":"offset-y"}},[a("v-btn",{attrs:{slot:"activator",flat:"flat",small:"small"},slot:"activator"},[e._v(e._s(e.userName)+"\n        "),a("v-icon",[e._v("keyboard_arrow_down")])],1),a("v-list",[a("v-list-tile",{on:{click:function(e){}}},[a("v-icon",{staticClass:"mr-2"},[e._v("settings")]),a("v-list-tile-title",[e._v("Settings")])],1),a("v-list-tile",{on:{click:e.logout}},[a("v-icon",{staticClass:"mr-2"},[e._v("exit_to_app")]),a("v-list-tile-title",[e._v("Logout")])],1)],1)],1),a("v-avatar",{staticClass:"mr-2",attrs:{size:"36"}},[a("img",{attrs:{src:"http://i.pravatar.cc/150?img=53"}})])],1),a("v-content",[a("v-container",{attrs:{fluid:"","fill-height":""}},[a("v-layout",[a("v-flex",{attrs:{"text-xs-center":""}},[a("router-view")],1)],1)],1)],1),a("v-footer",{attrs:{color:"secondary",app:""}},[a("span",{staticClass:"white--text"},[e._v("© 2017")])])],1)},n=[],i=(a("7f7f"),r["default"].extend({data:function(){return{drawer:null}},props:{source:String},methods:{logout:function(){this.$store.commit("logout"),this.$router.push({name:"login"})}},computed:{userName:function(){return this.$store.state.user.name}}})),o=i,c=(a("7faf"),a("2877")),l=Object(c["a"])(o,s,n,!1,null,null,null);l.options.__file="App.vue";var u=l.exports,d=(a("6762"),a("8c4f")),m=function(){var e=this,t=e.$createElement,a=e._self._c||t;return a("div",[a("v-text-field",{attrs:{"append-icon":"search",solo:"","single-line":"",placeholder:"Search..."},on:{keyup:function(t){return"button"in t||!e._k(t.keyCode,"enter",13,t.key,"Enter")?e.fastSearch(t):null}},model:{value:e.search,callback:function(t){e.search=t},expression:"search"}}),e.searching?a("v-progress-circular",{attrs:{size:50,color:"primary",indeterminate:""}}):e._e(),a("v-alert",{attrs:{value:e.searchError,type:"error"}},[e._v("\n    "+e._s(e.searchError)+"\n  ")]),a("v-container",{attrs:{"grid-list-md":"","text-xs-center":""}},[a("v-layout",{attrs:{row:"",wrap:""}},e._l(e.boardGames,function(t){return a("v-flex",{key:t.objectid,attrs:{xs6:""}},[a("v-card",[a("v-card-title",{attrs:{"primary-title":""}},[a("div",[a("h3",{staticClass:"headline mb-0"},[e._v(e._s(t.name))])])]),a("v-card-text",[a("v-list-tile",[a("v-list-tile-action",[a("v-icon",[e._v("event")])],1),a("v-list-tile-content",[a("v-list-tile-title",[e._v(e._s(t.yearPublished))]),a("v-list-tile-sub-title",[e._v("Year Published")])],1)],1)],1),a("v-card-actions",[t.imported?a("v-btn",{attrs:{block:"",color:"secondary"},on:{click:function(a){e.importGame(t.objectId)}}},[e._v("ReImport")]):a("v-btn",{attrs:{block:"",color:"primary"},on:{click:function(a){e.importGame(t.objectId)}}},[e._v("Import")])],1)],1)],1)}))],1)],1)},f=[],v=(a("386d"),a("96cf"),a("3040")),p=a("2ef0"),h=a.n(p),b=a("bc3a"),g=a.n(b),j="https://192.168.0.18:5001";console.log(window.uri),window.uri&&(j=window.uri);var y=g.a.create({baseURL:"".concat(j,"/api/"),headers:{"Access-Control-Allow-Origin":"*","Access-Control-Allow-Methods":"GET,PUT,POST,DELETE,PATCH,OPTIONS"}}),_=r["default"].extend({name:"home",components:{},data:function(){return{search:"",searching:!1,searchError:"",boardGames:[]}},methods:{slowSearch:h.a.debounce(Object(v["a"])(regeneratorRuntime.mark(function e(){return regeneratorRuntime.wrap(function(e){while(1)switch(e.prev=e.next){case 0:this.fastSearch();case 1:case"end":return e.stop()}},e,this)})),2e3),fastSearch:function(){var e=Object(v["a"])(regeneratorRuntime.mark(function e(){var t;return regeneratorRuntime.wrap(function(e){while(1)switch(e.prev=e.next){case 0:return this.searching=!0,e.prev=1,e.next=4,y.get("games/search-import?search=".concat(this.search));case 4:t=e.sent,this.boardGames=t.data,e.next=11;break;case 8:e.prev=8,e.t0=e["catch"](1),"Network Error"===e.t0.message&&(this.searchError="Network Error");case 11:this.searching=!1;case 12:case"end":return e.stop()}},e,this,[[1,8]])}));return function(){return e.apply(this,arguments)}}(),importGame:function(e){y.post("games",{objectid:e}).then(function(e){ie.push("games")})}},watch:{search:function(){var e=Object(v["a"])(regeneratorRuntime.mark(function e(){return regeneratorRuntime.wrap(function(e){while(1)switch(e.prev=e.next){case 0:this.search.length>2&&this.slowSearch();case 1:case"end":return e.stop()}},e,this)}));return function(){return e.apply(this,arguments)}}()}}),x=_,w=Object(c["a"])(x,m,f,!1,null,null,null);w.options.__file="Home.vue";var k=w.exports,S=function(){var e=this,t=e.$createElement,a=e._self._c||t;return a("div",[a("h1",[e._v("Imported Games")]),a("v-container",{attrs:{"grid-list-md":"","text-xs-center":""}},[a("v-alert",{attrs:{value:e.error,type:"error"}},[e._v("\n            "+e._s(e.error)+"\n        ")]),a("v-layout",{attrs:{row:"",wrap:""}},e._l(e.games,function(t){return a("v-flex",{key:t.objectId,attrs:{xs12:"",md6:"",lg4:""}},[a("v-card",[a("v-container",{attrs:{fluid:"","grid-list-lg":""}},[a("v-layout",{attrs:{row:""}},[a("v-flex",{attrs:{xs5:""}},[t.thumbnail?a("v-img",{attrs:{contain:"",src:t.thumbnail,"aspect-ratio":"1"}}):e._e()],1),a("v-flex",{attrs:{xs7:""}},[a("div",[a("div",{staticClass:"headline"},[e._v(e._s(t.name))]),a("div",[a("span",[a("v-icon",[e._v("people")]),e._v(" "+e._s(t.minPlayers)+" - "+e._s(t.maxPlayers)+"\n                                        ")],1)]),a("div",[a("span",[a("v-icon",[e._v("alarm")]),e._v(" "+e._s(t.minPlaytime)+'" - '+e._s(t.maxPlaytime)+'"\n                                        ')],1)])])])],1)],1),a("v-card-actions",[a("v-btn",{attrs:{small:"",absolute:"",top:"",right:"",fab:"",color:"error"},on:{click:function(a){e.deleteGame(t.id)}}},[a("v-icon",[e._v("delete")])],1),a("v-btn",{attrs:{to:{name:"game-session-create",params:{gameId:t.id}},color:"primary"}},[e._v("Create Session")]),a("v-btn",{attrs:{href:"https://boardgamegeek.com/boardgame/"+t.objectId,color:"secondary"}},[e._v("\n                            BGG Link\n                        ")])],1)],1)],1)}))],1)],1)},G=[],O=r["default"].extend({name:"GameList",data:function(){return{games:null,error:""}},created:function(){this.getGames()},methods:{getGames:function(){var e=Object(v["a"])(regeneratorRuntime.mark(function e(){return regeneratorRuntime.wrap(function(e){while(1)switch(e.prev=e.next){case 0:return e.prev=0,e.next=3,y.get("games");case 3:this.games=e.sent.data,e.next=9;break;case 6:e.prev=6,e.t0=e["catch"](0),this.error=e.t0;case 9:case"end":return e.stop()}},e,this,[[0,6]])}));return function(){return e.apply(this,arguments)}}(),deleteGame:function(e){var t=this;y.delete("games/".concat(e)).then(function(e){t.getGames()})}}}),z=O,P=(a("2f5e"),Object(c["a"])(z,S,G,!1,null,null,null));P.options.__file="GameList.vue";var C=P.exports,I=function(){var e=this,t=e.$createElement,a=e._self._c||t;return a("div",[a("h1",[e._v("Game Sessions")]),a("router-link",{attrs:{to:{name:"game-session-create"}}},[a("v-btn",{attrs:{color:"primary"}},[e._v("\n      New\n    ")])],1),[a("v-data-table",{staticClass:"elevation-1",attrs:{headers:e.headers,items:e.gameSessions,"hide-actions":""},scopedSlots:e._u([{key:"items",fn:function(t){return[a("td",[a("router-link",{attrs:{to:{name:"game-session-detail",params:{id:t.item.id}}}},[e._v(e._s(t.item.gameName))])],1),a("td",[e._v(e._s(e._f("date")(t.item.date)))]),a("td",[e._v(e._s(t.item.ratings.length))])]}}])})]],2)},R=[],E=r["default"].extend({name:"GameSessionList",data:function(){return{headers:[{text:"Game",value:"game"},{text:"Date",value:"date"},{text:"Num of Players",value:"players"}],gameSessions:[]}},created:function(){var e=this;y.get("game-session").then(function(t){e.gameSessions=t.data})}}),$=E,N=(a("5972"),Object(c["a"])($,I,R,!1,null,null,null));N.options.__file="GameSessionList.vue";var L=N.exports,D=function(){var e=this,t=e.$createElement,a=e._self._c||t;return a("div",[a("h1",[e._v("Game Session Details")]),e.loading?a("v-progress-circular",{attrs:{size:50,color:"primary",indeterminate:""}}):e._e(),e.loading?e._e():a("div",[a("h1",[e._v(e._s(e.session.gameName))]),a("v-data-table",{staticClass:"elevation-1",attrs:{headers:e.headers,items:e.session.ratings,"hide-actions":""},scopedSlots:e._u([{key:"items",fn:function(t){return[a("td",[e.player.id==t.item.playerId?a("span",{staticStyle:{color:"forestgreen"}},[e._v("(You)")]):e._e(),e._v(" "+e._s(t.item.playerName)+" ")]),a("td",[a("star-rating",{attrs:{"star-size":25},on:{"rating-selected":function(a){e.ratingChanged(t.item.rating,t.item.playerId)}},model:{value:t.item.rating,callback:function(a){e.$set(t.item,"rating",a)},expression:"props.item.rating"}})],1)]}}])})],1)],1)},T=[],F=(a("c5f6"),a("c1da")),U=a.n(F),q=r["default"].extend({name:"GameSessionDetails",components:{StarRating:U.a},props:{id:{type:Number,required:!0}},data:function(){return{loading:!0,headers:[{text:"Player",value:"player"},{text:"Rating",value:"rating"}],session:{}}},methods:{ratingChanged:function(){var e=Object(v["a"])(regeneratorRuntime.mark(function e(t,a){return regeneratorRuntime.wrap(function(e){while(1)switch(e.prev=e.next){case 0:return e.prev=0,e.next=3,y.post("rating/gameplay-session/".concat(this.id,"/player/").concat(a),{rating:t});case 3:e.next=7;break;case 5:e.prev=5,e.t0=e["catch"](0);case 7:case"end":return e.stop()}},e,this,[[0,5]])}));return function(t,a){return e.apply(this,arguments)}}()},computed:{player:function(){return this.$store.state.user}},mounted:function(){var e=Object(v["a"])(regeneratorRuntime.mark(function e(){return regeneratorRuntime.wrap(function(e){while(1)switch(e.prev=e.next){case 0:return this.loading=!0,e.prev=1,e.next=4,y.get("game-session/".concat(this.id));case 4:this.session=e.sent.data,e.next=9;break;case 7:e.prev=7,e.t0=e["catch"](1);case 9:this.loading=!1;case 10:case"end":return e.stop()}},e,this,[[1,7]])}));return function(){return e.apply(this,arguments)}}()}),M=q,A=(a("d247"),Object(c["a"])(M,D,T,!1,null,null,null));A.options.__file="GameSessionDetails.vue";var Y=A.exports,J=function(){var e=this,t=e.$createElement,a=e._self._c||t;return a("div",[a("h1",[e._v("Game Create")]),e.isLoading?a("v-progress-circular",{attrs:{size:50,color:"primary",indeterminate:""}}):a("v-form",{model:{value:e.valid,callback:function(t){e.valid=t},expression:"valid"}},[a("v-autocomplete",{attrs:{items:e.games,"item-value":"id","item-text":"name",label:"Game"},model:{value:e.selectedGame,callback:function(t){e.selectedGame=t},expression:"selectedGame"}}),a("v-flex",[a("v-dialog",{ref:"dialog",attrs:{"return-value":e.date,persistent:"",lazy:"","full-width":"",width:"290px"},on:{"update:returnValue":function(t){e.date=t}},model:{value:e.modal,callback:function(t){e.modal=t},expression:"modal"}},[a("v-text-field",{attrs:{slot:"activator",label:"Picker in dialog",readonly:""},slot:"activator",model:{value:e.date,callback:function(t){e.date=t},expression:"date"}}),a("v-date-picker",{attrs:{scrollable:""},model:{value:e.date,callback:function(t){e.date=t},expression:" date"}},[a("v-spacer"),a("v-btn",{attrs:{flat:"",color:"primary"},on:{click:function(t){e.modal=!1}}},[e._v("Cancel")]),a("v-btn",{attrs:{flat:"",color:"primary"},on:{click:function(t){e.$refs.dialog.save(e.date)}}},[e._v("OK")])],1)],1)],1),a("v-combobox",{attrs:{items:e.players,label:"Players",multiple:"","item-text":"name","item-value":"name",type:"text"},model:{value:e.selectedPlayers,callback:function(t){e.selectedPlayers=t},expression:"selectedPlayers"}}),a("v-btn",{attrs:{color:"primary"},on:{click:e.submit}},[e._v(" Save ")])],1)],1)},B=[],H=r["default"].extend({name:"GameSessionCreate",props:{gameId:{type:Number}},data:function(){return{isLoading:!0,modal:!1,games:[],players:[],selectedGame:0,selectedPlayers:[],date:(new Date).toISOString().substr(0,10)}},created:function(){var e=Object(v["a"])(regeneratorRuntime.mark(function e(){return regeneratorRuntime.wrap(function(e){while(1)switch(e.prev=e.next){case 0:return this.isLoading=!0,e.prev=1,e.next=4,y.get("games");case 4:return this.games=e.sent.data,e.next=7,y.get("player");case 7:this.players=e.sent.data,this.gameId&&(this.selectedGame=this.gameId),e.next=13;break;case 11:e.prev=11,e.t0=e["catch"](1);case 13:this.isLoading=!1;case 14:case"end":return e.stop()}},e,this,[[1,11]])}));return function(){return e.apply(this,arguments)}}(),methods:{submit:function(){var e=Object(v["a"])(regeneratorRuntime.mark(function e(){var t;return regeneratorRuntime.wrap(function(e){while(1)switch(e.prev=e.next){case 0:return e.prev=0,e.next=3,y.post("game-session",{gameId:this.selectedGame,date:this.date,players:this.selectedPlayers.map(function(e){return e.id})});case 3:t=e.sent.data,this.$router.push({name:"game-session-detail",params:{id:t}}),e.next=9;break;case 7:e.prev=7,e.t0=e["catch"](0);case 9:case"end":return e.stop()}},e,this,[[0,7]])}));return function(){return e.apply(this,arguments)}}()}}),K=H,V=(a("db9d"),Object(c["a"])(K,J,B,!1,null,null,null));V.options.__file="GameSessionCreate.vue";var Q=V.exports,W=function(){var e=this,t=e.$createElement,a=e._self._c||t;return a("v-container",[e.error?a("v-layout",{attrs:{row:""}},[a("v-flex",{attrs:{xs12:"",sm6:"","offset-sm3":""}},[a("v-alert",{attrs:{value:e.error,type:"error"}},[e._v("\n                "+e._s(e.error)+"\n            ")])],1)],1):e._e(),e._v("\n    "+e._s(e.error)+"\n    "),a("v-layout",{attrs:{row:""}},[a("v-flex",{attrs:{xs12:"",sm6:"","offset-sm3":""}},[a("v-card",[a("v-card-text",[a("v-container",[a("form",{on:{submit:function(t){return t.preventDefault(),e.signIn(t)}}},[a("v-layout",{attrs:{row:""}},[a("v-flex",{attrs:{xs12:""}},[a("v-text-field",{attrs:{name:"email",label:"Username",required:""},model:{value:e.username,callback:function(t){e.username=t},expression:"username"}})],1)],1),a("v-layout",{attrs:{row:""}},[a("v-flex",{attrs:{xs12:""}},[a("v-text-field",{attrs:{name:"password",label:"Password",id:"password",type:"password",required:""},model:{value:e.password,callback:function(t){e.password=t},expression:"password"}})],1)],1),a("v-layout",{attrs:{row:""}},[a("v-flex",{attrs:{xs12:""}},[a("v-btn",{attrs:{type:"submit",disabled:e.loading,loading:e.loading,color:"primary"}},[e._v("\n                                        Sign in\n                                        "),a("span",{staticClass:"custom-loader",attrs:{slot:"loader"},slot:"loader"},[a("v-icon",{attrs:{light:""}},[e._v("cached")])],1)])],1)],1)],1)])],1)],1)],1)],1)],1)},X=[],Z=r["default"].extend({name:"Login",data:function(){return{error:"",loading:!1,username:"",password:""}},methods:{signIn:function(){var e=Object(v["a"])(regeneratorRuntime.mark(function e(){var t,a;return regeneratorRuntime.wrap(function(e){while(1)switch(e.prev=e.next){case 0:return this.loading=!0,e.prev=1,e.next=4,y.post("Users/authenticate",{username:this.username,password:this.password});case 4:t=e.sent.data,a={id:t.id,name:t.name,token:t.token},this.$store.commit("setUser",a),this.$route.query.redirect?this.$router.push(this.$route.query.redirect):this.$router.push({name:"home"}),e.next=13;break;case 10:e.prev=10,e.t0=e["catch"](1),this.error=e.t0;case 13:this.loading=!1;case 14:case"end":return e.stop()}},e,this,[[1,10]])}));return function(){return e.apply(this,arguments)}}()}}),ee=Z,te=(a("d6db"),Object(c["a"])(ee,W,X,!1,null,null,null));te.options.__file="Login.vue";var ae=te.exports,re=a("2f62");r["default"].use(re["a"]);var se=new re["a"].Store({state:{user:{}},mutations:{setUser:function(e,t){e.user=t,localStorage.setItem("user",JSON.stringify(t))},logout:function(e){e.user={},localStorage.removeItem("user")}},actions:{}});r["default"].use(d["a"]);var ne=new d["a"]({mode:"history",base:"/",routes:[{path:"/home",name:"home",component:k},{path:"/games",name:"games",component:C},{path:"/game-session",name:"game-sessions",component:L},{path:"/game-session/create/:gameId?",name:"game-session-create",component:Q,props:!0},{path:"/game-session/:id",name:"game-session-detail",component:Y,props:!0},{name:"login",path:"/login",component:ae}]}),ie=ne;ne.beforeEach(function(e,t,a){var r=["/login","/register"],s=!r.includes(e.path);if(void 0===se.state.user.token){var n=localStorage.getItem("user");if(n){var i=JSON.parse(n);se.commit("setUser",i)}}var o=void 0!=se.state.user.token;if(s&&!o)return a({path:"/login",query:{redirect:e.fullPath}});a()});var oe=a("ce5b"),ce=a.n(oe),le=a("c1df"),ue=a.n(le);r["default"].use(ce.a,{theme:{primary:"#2e7d32",secondary:"#424242",accent:"#82B1FF",error:"#FF5252",info:"#2196F3",success:"#4CAF50",warning:"#FFC107"}}),r["default"].config.productionTip=!1,r["default"].filter("date",function(e){return ue()(e).format("DD/MM/YYYY")}),new r["default"]({router:ie,store:se,render:function(e){return e(u)}}).$mount("#app")},d247:function(e,t,a){"use strict";var r=a("910e"),s=a.n(r);s.a},d6db:function(e,t,a){"use strict";var r=a("05b0"),s=a.n(r);s.a},db9d:function(e,t,a){"use strict";var r=a("fc5d"),s=a.n(r);s.a},fc5d:function(e,t,a){}});
//# sourceMappingURL=app.7d07fb75.js.map