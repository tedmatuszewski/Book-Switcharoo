(function(t){function a(a){for(var e,r,n=a[0],l=a[1],c=a[2],d=0,m=[];d<n.length;d++)r=n[d],o[r]&&m.push(o[r][0]),o[r]=0;for(e in l)Object.prototype.hasOwnProperty.call(l,e)&&(t[e]=l[e]);u&&u(a);while(m.length)m.shift()();return i.push.apply(i,c||[]),s()}function s(){for(var t,a=0;a<i.length;a++){for(var s=i[a],e=!0,n=1;n<s.length;n++){var l=s[n];0!==o[l]&&(e=!1)}e&&(i.splice(a--,1),t=r(r.s=s[0]))}return t}var e={},o={app:0},i=[];function r(a){if(e[a])return e[a].exports;var s=e[a]={i:a,l:!1,exports:{}};return t[a].call(s.exports,s,s.exports,r),s.l=!0,s.exports}r.m=t,r.c=e,r.d=function(t,a,s){r.o(t,a)||Object.defineProperty(t,a,{enumerable:!0,get:s})},r.r=function(t){"undefined"!==typeof Symbol&&Symbol.toStringTag&&Object.defineProperty(t,Symbol.toStringTag,{value:"Module"}),Object.defineProperty(t,"__esModule",{value:!0})},r.t=function(t,a){if(1&a&&(t=r(t)),8&a)return t;if(4&a&&"object"===typeof t&&t&&t.__esModule)return t;var s=Object.create(null);if(r.r(s),Object.defineProperty(s,"default",{enumerable:!0,value:t}),2&a&&"string"!=typeof t)for(var e in t)r.d(s,e,function(a){return t[a]}.bind(null,e));return s},r.n=function(t){var a=t&&t.__esModule?function(){return t["default"]}:function(){return t};return r.d(a,"a",a),a},r.o=function(t,a){return Object.prototype.hasOwnProperty.call(t,a)},r.p="/";var n=window["webpackJsonp"]=window["webpackJsonp"]||[],l=n.push.bind(n);n.push=a,n=n.slice();for(var c=0;c<n.length;c++)a(n[c]);var u=l;i.push([0,"chunk-vendors"]),s()})({0:function(t,a,s){t.exports=s("56d7")},"1feb":function(t,a,s){"use strict";var e=function(){var t=this,a=t.$createElement,s=t._self._c||a;return s("div",{staticClass:"container flex-grow-1"},[s("form",{staticClass:"form-signin",on:{submit:function(a){return a.preventDefault(),t.register(a)}}},[t.error?s("div",{staticClass:"alert alert-danger",attrs:{role:"alert"}},[t._v("\n            "+t._s(t.error)+"\n        ")]):t._e(),s("h1",{staticClass:"h3 mb-3 font-weight-normal"},[t._v("Please sign in")]),s("label",[t._v("Email address")]),s("input",{directives:[{name:"model",rawName:"v-model",value:t.email,expression:"email"}],staticClass:"form-control",attrs:{type:"email",required:"",autofocus:""},domProps:{value:t.email},on:{input:function(a){a.target.composing||(t.email=a.target.value)}}}),s("label",[t._v("Password")]),s("input",{directives:[{name:"model",rawName:"v-model",value:t.password,expression:"password"}],staticClass:"form-control",attrs:{type:"password",placeholder:"Password",required:""},domProps:{value:t.password},on:{input:function(a){a.target.composing||(t.password=a.target.value)}}}),s("button",{staticClass:"btn btn-lg btn-primary btn-block",attrs:{type:"submit"}},[t._v("Register")])])])},o=[],i=(s("cadf"),s("551c"),s("097d"),s("8aa5")),r=s.n(i),n={data:function(){return{password:"",email:"",error:null}},methods:{register:function(){var t=this;r.a.auth().createUserWithEmailAndPassword(t.email,t.password).then(function(){},function(a){t.error=a.message})}},mounted:function(){}},l=n,c=s("2877"),u=Object(c["a"])(l,e,o,!1,null,"65a1ae7d",null);a["a"]=u.exports},"3dfd":function(t,a,s){"use strict";var e=function(){var t=this,a=t.$createElement,s=t._self._c||a;return s("div",[s("b-navbar",{attrs:{toggleable:"sm",type:"dark",variant:"info"}},[s("b-navbar-toggle",{attrs:{target:"nav_collapse"}}),s("b-navbar-brand",{attrs:{href:"#"}},[t._v("Book Swap")]),s("b-collapse",{attrs:{"is-nav":"",id:"nav_collapse"}},[s("b-navbar-nav",[s("router-link",{staticClass:"nav-item",attrs:{tag:"li",to:"/"}},[s("a",{staticClass:"nav-link",attrs:{href:"#"}},[t._v("Home")])]),s("router-link",{staticClass:"nav-item",attrs:{tag:"li",to:"/post"}},[s("a",{staticClass:"nav-link",attrs:{href:"#"}},[t._v("Post")])])],1),s("b-navbar-nav",{staticClass:"ml-auto"},[s("b-nav-item-dropdown",{attrs:{right:""}},[s("template",{slot:"button-content"},[t._v("\n                        "+t._s(t.$store.user)+"\n                    ")]),s("b-dropdown-item",{attrs:{to:"/profile"}},[t._v("Profile")]),s("b-dropdown-item",{attrs:{href:"#"}},[t._v("Signout")])],2)],1)],1)],1),s("router-view"),t._m(0)],1)},o=[function(){var t=this,a=t.$createElement,s=t._self._c||a;return s("footer",{staticClass:"footer mt-auto py-3"},[s("div",{staticClass:"container"},[s("span",{staticClass:"text-muted"},[t._v("Book Swap 2019")])])])}],i=(s("cadf"),s("551c"),s("097d"),{name:"app",store:["user"],mounted:function(){}}),r=i,n=s("2877"),l=Object(n["a"])(r,e,o,!1,null,null,null);a["a"]=l.exports},"56d7":function(t,a,s){"use strict";s.r(a),function(t){s("cadf"),s("551c"),s("097d");var a=s("2b0e"),e=s("3dfd"),o=s("bc3a"),i=s.n(o),r=s("a7fe"),n=s.n(r),l=s("8c4f"),c=s("9f7b"),u=s("8aa5"),d=s.n(u),m=s("3f9b"),p=s("f8ac"),v=s.n(p),f=s("7dc5"),b=(s("f9e3"),s("2dd8"),s("57da")),h=s("c106"),C=s("9c93"),g=s("578a"),k=s("1feb"),_=s("66aa");a["a"].config.productionTip=!0,i.a.defaults.baseURL=f.api_url;var y={apiKey:"AIzaSyC-vQIqz2ESYm0cuF9UswndGcXokxC2PGE",authDomain:"bookswap633.firebaseapp.com",databaseURL:"https://bookswap633.firebaseio.com",projectId:"bookswap633",storageBucket:"",messagingSenderId:"95979622512"};d.a.initializeApp(y),a["a"].use(v.a),a["a"].use(m["a"]),a["a"].use(n.a,i.a),a["a"].use(l["a"]),a["a"].use(c["a"]);var w=new l["a"]({base:t,linkExactActiveClass:"active",routes:[{path:"/",name:"home",component:b["a"]},{path:"/search",name:"search",component:h["a"]},{path:"/post/:id",name:"editpost",component:C["a"],meta:{requiresAuth:!0}},{path:"/post",name:"createpost",component:C["a"],meta:{requiresAuth:!0}},{path:"/login",name:"login",component:g["a"]},{path:"/register",name:"register",component:k["a"]},{path:"/profile",name:"profile",component:_["a"],meta:{requiresAuth:!0}}]});w.beforeEach(function(t,a,s){var e=d.a.auth().currentUser,o=t.matched.some(function(t){return t.meta.requiresAuth});o&&!e?w.push({path:"/login",query:{redirectTo:t.path}}):s()}),new a["a"]({router:w,data:{store:{}},created:function(){var t=this;d.a.auth().onAuthStateChanged(function(a){a&&(t.$store.user=a.email)})},render:function(t){return t(e["a"])}}).$mount("#app")}.call(this,"/")},"578a":function(t,a,s){"use strict";var e=function(){var t=this,a=t.$createElement,s=t._self._c||a;return s("div",{staticClass:"container flex-grow-1"},[s("form",{staticClass:"form-signin",on:{submit:function(a){return a.preventDefault(),t.login(a)}}},[t.error?s("div",{staticClass:"alert alert-danger",attrs:{role:"alert"}},[t._v("\n            "+t._s(t.error)+"\n        ")]):t._e(),s("h1",{staticClass:"h3 mb-3 font-weight-normal"},[t._v("Please sign in")]),s("label",{staticClass:"sr-only",attrs:{for:"inputEmail"}},[t._v("Email address")]),s("input",{directives:[{name:"model",rawName:"v-model",value:t.email,expression:"email"}],staticClass:"form-control",attrs:{type:"email",placeholder:"Email address",required:"",autofocus:""},domProps:{value:t.email},on:{input:function(a){a.target.composing||(t.email=a.target.value)}}}),s("label",{staticClass:"sr-only",attrs:{for:"inputPassword"}},[t._v("Password")]),s("input",{directives:[{name:"model",rawName:"v-model",value:t.password,expression:"password"}],staticClass:"form-control",attrs:{type:"password",placeholder:"Password",required:""},domProps:{value:t.password},on:{input:function(a){a.target.composing||(t.password=a.target.value)}}}),s("button",{staticClass:"btn btn-lg btn-primary btn-block",attrs:{type:"submit"}},[t._v("Sign in")])])])},o=[],i=s("8aa5"),r=s.n(i),n={props:["redirectTo"],store:["user"],data:function(){return{password:"",email:"",error:null}},methods:{login:function(){var t=this;r.a.auth().setPersistence(r.a.auth.Auth.Persistence.LOCAL).then(function(){return r.a.auth().signInWithEmailAndPassword(t.email,t.password).then(function(){t.$store.user=t.email,null!=t.$route.query.redirectTo?t.$router.push({path:t.$route.query.redirectTo}):t.$router.push({path:"/profile"})},function(a){t.error=a.message})})}},mounted:function(){}},l=n,c=s("2877"),u=Object(c["a"])(l,e,o,!1,null,"fbead368",null);a["a"]=u.exports},"57da":function(t,a,s){"use strict";var e=function(){var t=this,a=t.$createElement,s=t._self._c||a;return s("div",{staticClass:"home"},[s("div",{staticClass:"poster-container"},[s("div",{staticClass:"poster-overlay"}),s("div",{staticClass:"poster-search-container"},[s("h1",[t._v("Find your Next Book")]),s("p",[t._v("Type a title or ISBN")]),s("div",{staticClass:"poster-search"},[s("div",{staticClass:"input-group"},[s("i",{staticClass:"fa fa-search"}),s("input",{directives:[{name:"model",rawName:"v-model",value:t.term,expression:"term"}],staticClass:"form-control form-control-lg",attrs:{type:"text",placeholder:"Enter a keyword..."},domProps:{value:t.term},on:{input:function(a){a.target.composing||(t.term=a.target.value)}}}),s("div",{staticClass:"input-group-append"},[s("button",{staticClass:"btn-poster-search btn btn-primary",attrs:{type:"button"},on:{click:t.search}},[t._v("Search")])])])])])]),s("div",{staticClass:"container-fluid"},[s("div",{directives:[{name:"masonry",rawName:"v-masonry"}],staticClass:"mx-auto",attrs:{"transition-duration":"0.5s","item-selector":".card",gutter:"20","fit-width":"false"}},t._l(t.books,function(a){return s("div",{directives:[{name:"masonry-tile",rawName:"v-masonry-tile"}],key:a.Id,staticClass:"card book",staticStyle:{width:"20rem"},on:{click:function(s){t.viewBook(a)}}},[s("img",{staticClass:"card-img-top",attrs:{src:a.Image,alt:a.Title}}),s("div",{staticClass:"card-body"},[s("h5",{staticClass:"card-title"},[t._v(t._s(a.Title))]),s("p",{staticClass:"my-0 text-muted"},[s("small",[s("i",{staticClass:"fa fa-book"}),t._v(" "+t._s(a.Isbn))])]),s("p",{staticClass:"my-0 text-muted"},[s("small",[s("i",{staticClass:"fa fa-building"}),t._v(" "+t._s(a.UniversityDisplay))])])]),s("div",{staticClass:"card-footer text-muted"},[s("small",[s("i",{staticClass:"fa fa-calendar"}),t._v(" "+t._s(a.DaysAgo))])])])}))]),t.isBookModalOpen?s("div",[s("transition",{attrs:{name:"modal"}},[s("div",{staticClass:"modal-mask"},[s("div",{staticClass:"modal-wrapper"},[s("div",{staticClass:"modal-dialog",attrs:{role:"document"}},[s("div",{staticClass:"modal-content"},[s("div",{staticClass:"modal-header"},[s("h5",{staticClass:"modal-title"},[t._v(t._s(t.bookModal.Title))]),s("button",{staticClass:"close",attrs:{type:"button","data-dismiss":"modal","aria-label":"Close"},on:{click:function(a){t.isBookModalOpen=!1}}},[s("span",{attrs:{"aria-hidden":"true"}},[t._v("×")])])]),s("div",{staticClass:"modal-body"},[s("img",{attrs:{src:t.bookModal.Image}}),s("div",{staticClass:"row"},[s("div",{staticClass:"col-sm-4"},[t._v("Description:")]),s("div",{staticClass:"col-sm-8"},[t._v(t._s(t.bookModal.Description))])]),s("div",{staticClass:"row"},[s("div",{staticClass:"col-sm-4"},[t._v("University/Class:")]),s("div",{staticClass:"col-sm-8"},[t._v(t._s(t.bookModal.UniversityDisplay))])]),s("div",{staticClass:"row"},[s("div",{staticClass:"col-sm-4"},[t._v("ISBN:")]),s("div",{staticClass:"col-sm-8"},[t._v(t._s(t.bookModal.Isbn))])]),s("div",{staticClass:"row"},[s("div",{staticClass:"col-sm-4"},[t._v("Condition:")]),s("div",{staticClass:"col-sm-8"},[t._v(t._s(t.bookModal.Condition))])]),s("div",{staticClass:"row"},[s("div",{staticClass:"col-sm-4"},[t._v("Date Posted:")]),s("div",{staticClass:"col-sm-8"},[t._v(t._s(t.bookModal.DateAddedDisplay))])])]),s("div",{staticClass:"modal-footer"},[s("button",{staticClass:"btn btn-primary",attrs:{type:"button"}},[s("i",{staticClass:"fa fa-comments"}),t._v(" Message")]),s("button",{staticClass:"btn btn-secondary",attrs:{type:"button"},on:{click:function(a){t.isBookModalOpen=!1}}},[s("i",{staticClass:"fa fa-times"}),t._v(" Close")])])])])])])])],1):t._e()])},o=[],i=(s("cadf"),s("551c"),s("097d"),{name:"Home",data:function(){return{books:[],term:"",isBookModalOpen:!1,bookModal:{}}},methods:{search:function(){this.$router.push({name:"search",params:{term:this.term}})},viewBook:function(t){var a=this;a.$http.get("/v1/books/"+t.Id).then(function(t){a.bookModal=t.data}),a.isBookModalOpen=!0}},mounted:function(){var t=this;t.$http.get("v1/books").then(function(a){t.books=a.data})}}),r=i,n=s("2877"),l=Object(n["a"])(r,e,o,!1,null,"995bc80a",null);a["a"]=l.exports},"66aa":function(t,a,s){"use strict";var e=function(){var t=this,a=t.$createElement,s=t._self._c||a;return s("div",{staticClass:"container-fluid"},[s("div",{staticClass:"row mt-4"},[s("div",{staticClass:"col-sm-8"},[s("h3",[t._v("Your library")]),t._l(t.Books,function(a,e){return s("div",{key:a.Id,staticClass:"card mb-3"},[s("div",{staticClass:"card-body"},[s("div",{staticClass:"row"},[s("div",{staticClass:"col-sm-4 col-md-3 col-lg-2"},[s("img",{staticClass:"img-fluid",staticStyle:{"max-height":"150px"},attrs:{src:a.Image,alt:a.Title}})]),s("div",{staticClass:"col-sm-8"},[s("h5",{staticClass:"card-title"},[t._v(t._s(a.Title))]),s("h6",{staticClass:"card-subtitle mb-2 text-muted"},[t._v(t._s(a.Isbn))]),s("p",{staticClass:"card-text"},[t._v(t._s(a.Description)+".")]),s("router-link",{staticClass:"card-link",attrs:{tag:"a",to:{name:"editpost",params:{id:a.Id}}}},[t._v("Edit")]),s("a",{staticClass:"card-link",attrs:{href:"#"},on:{click:function(s){s.preventDefault(),t.deleteBook(a,e)}}},[t._v("Delete")])],1)])])])})],2),s("div",{staticClass:"col-sm-4"})])])},o=[],i=(s("cadf"),s("551c"),s("097d"),{data:function(){return{Books:[]}},methods:{deleteBook:function(t,a){var s=this;s.$http.delete("/v1/books/"+t.Id).then(function(){s.Books.splice(a,1)})}},mounted:function(){var t=this;t.$http.get("/v1/books?owner="+t.$store.user).then(function(a){t.Books=a.data})}}),r=i,n=s("2877"),l=Object(n["a"])(r,e,o,!1,null,"3c0da7b6",null);a["a"]=l.exports},"7dc5":function(t){t.exports={api_url:"http://localhost:50763/"}},"9c93":function(t,a,s){"use strict";var e=function(){var t=this,a=t.$createElement,s=t._self._c||a;return s("div",{staticClass:"container"},[s("div",{staticClass:"card mt-5"},[s("div",{staticClass:"card-body"},[s("h5",{staticClass:"card-title"},[t._v("Post your book")]),s("hr"),s("div",{staticClass:"row"},[s("div",{staticClass:"col-sm-4"},[s("div",{staticClass:"jumbotron text-center"},[s("img",{staticClass:"img-fluid",staticStyle:{"min-height":"250px"},attrs:{src:t.book.Image}})])]),s("div",{staticClass:"col-sm-8"},[s("form",{attrs:{enctype:"multipart/form-data"},on:{submit:function(a){return a.preventDefault(),t.bookSubmit(a)}}},[s("div",{staticClass:"row"},[s("div",{staticClass:"col-sm-6"},[s("div",{staticClass:"form-group"},[s("label",{staticClass:"form-label"},[t._v("Title")]),s("input",{directives:[{name:"model",rawName:"v-model",value:t.book.Title,expression:"book.Title"}],staticClass:"form-control",domProps:{value:t.book.Title},on:{input:function(a){a.target.composing||t.$set(t.book,"Title",a.target.value)}}})])]),s("div",{staticClass:"col-sm-6"},[s("div",{staticClass:"form-group"},[s("label",{staticClass:"form-label"},[t._v("ISBN")]),s("input",{directives:[{name:"model",rawName:"v-model",value:t.book.Isbn,expression:"book.Isbn"}],staticClass:"form-control",domProps:{value:t.book.Isbn},on:{input:function(a){a.target.composing||t.$set(t.book,"Isbn",a.target.value)}}})])])]),s("div",{staticClass:"row"},[s("div",{staticClass:"col-sm-8"},[s("div",{staticClass:"form-group"},[s("label",{staticClass:"form-label"},[t._v("University")]),s("input",{directives:[{name:"model",rawName:"v-model",value:t.book.University,expression:"book.University"}],staticClass:"form-control",domProps:{value:t.book.University},on:{input:function(a){a.target.composing||t.$set(t.book,"University",a.target.value)}}})])]),s("div",{staticClass:"col-sm-4"},[s("div",{staticClass:"form-group"},[s("label",{staticClass:"form-label"},[t._v("Class")]),s("input",{directives:[{name:"model",rawName:"v-model",value:t.book.Class,expression:"book.Class"}],staticClass:"form-control",domProps:{value:t.book.Class},on:{input:function(a){a.target.composing||t.$set(t.book,"Class",a.target.value)}}})])])]),s("div",{staticClass:"row"},[s("div",{staticClass:"col-sm-7"},[s("div",{staticClass:"form-group"},[s("label",{staticClass:"form-label"},[t._v("Image")]),s("input",{ref:"filePicker",staticClass:"form-control",attrs:{type:"file",accept:".gif,.jpg,.jpeg,.png"},on:{change:function(a){t.encodeImage()}}})])]),s("div",{staticClass:"col-sm-5"},[s("div",{staticClass:"form-group"},[s("label",{staticClass:"form-label"},[t._v("Condition")]),s("select",{directives:[{name:"model",rawName:"v-model",value:t.book.Condition,expression:"book.Condition"}],staticClass:"form-control",on:{change:function(a){var s=Array.prototype.filter.call(a.target.options,function(t){return t.selected}).map(function(t){var a="_value"in t?t._value:t.value;return a});t.$set(t.book,"Condition",a.target.multiple?s:s[0])}}},[s("option",{attrs:{value:"Like New"}},[t._v("Like New")]),s("option",{attrs:{value:"Very Good"}},[t._v("Very Good")]),s("option",{attrs:{value:"Good"}},[t._v("Good")]),s("option",{attrs:{value:"Poor"}},[t._v("Poor")]),s("option",{attrs:{value:"Very Poor"}},[t._v("Very Poor")])])])])]),s("div",{staticClass:"form-group"},[s("label",{staticClass:"form-label"},[t._v("Description your book")]),s("textarea",{directives:[{name:"model",rawName:"v-model",value:t.book.Description,expression:"book.Description"}],staticClass:"form-control",domProps:{value:t.book.Description},on:{input:function(a){a.target.composing||t.$set(t.book,"Description",a.target.value)}}})]),s("input",{directives:[{name:"model",rawName:"v-model",value:t.book.Id,expression:"book.Id"}],attrs:{type:"hidden"},domProps:{value:t.book.Id},on:{input:function(a){a.target.composing||t.$set(t.book,"Id",a.target.value)}}}),s("input",{directives:[{name:"model",rawName:"v-model",value:t.book.Image,expression:"book.Image"}],attrs:{type:"hidden"},domProps:{value:t.book.Image},on:{input:function(a){a.target.composing||t.$set(t.book,"Image",a.target.value)}}}),s("input",{directives:[{name:"model",rawName:"v-model",value:t.book.User,expression:"book.User"}],attrs:{type:"hidden"},domProps:{value:t.book.User},on:{input:function(a){a.target.composing||t.$set(t.book,"User",a.target.value)}}}),s("input",{directives:[{name:"model",rawName:"v-model",value:t.book.IsDeleted,expression:"book.IsDeleted"}],attrs:{type:"hidden"},domProps:{value:t.book.IsDeleted},on:{input:function(a){a.target.composing||t.$set(t.book,"IsDeleted",a.target.value)}}}),t._m(0)])])])])])])},o=[function(){var t=this,a=t.$createElement,s=t._self._c||a;return s("div",{staticClass:"form-group"},[s("button",{staticClass:"btn btn-primary float-right",attrs:{type:"submit"}},[t._v("Submit")])])}],i=(s("cadf"),s("551c"),s("097d"),s("8aa5")),r=s.n(i),n={props:["id"],data:function(){return{file:null,book:{}}},methods:{bookSubmit:function(){var t=this;null==t.$route||null==t.$route.params||null==t.$route.params.id?t.$http.post("/v1/books",t.book).then(function(){t.book={},t.$refs.filePicker.value=""}):t.$http.put("/v1/books/"+t.$route.params.id,t.book).then(function(){t.$router.push({path:"/profile"})})},encodeImage:function(){var t=new FormData,a=this.$refs.filePicker.files[0],s=this;t.append("file",a),this.$http.post("/v1/file",t,{headers:{"Content-Type":"multipart/form-data"}}).then(function(t){s.book.Image=t.data}).catch(function(){})}},mounted:function(){var t=this;t.book.User=r.a.auth().currentUser.email,t.book.IsDeleted=!1,t.book.Type="Library",null!=t.$route&&null!=t.$route.params&&null!=t.$route.params.id&&t.$http.get("/v1/books/"+t.$route.params.id).then(function(a){t.book=a.data})}},l=n,c=s("2877"),u=Object(c["a"])(l,e,o,!1,null,"156a2b82",null);a["a"]=u.exports},c106:function(t,a,s){"use strict";var e=function(){var t=this,a=t.$createElement,s=t._self._c||a;return s("div",{staticClass:"container"},[s("div",{staticClass:"my-5 text-center"},[s("h3",[t._v("You searched for "),s("u",[t._v(t._s(this.$route.params.term))]),t._v(". Click "),s("router-link",{attrs:{tag:"a",to:"/"}},[t._v("here")]),t._v(" to search for another book.")],1)]),s("div",{staticClass:"list-group"},t._l(t.books,function(a){return s("a",{key:a.Id,staticClass:"list-group-item list-group-item-action",attrs:{href:"#"}},[s("img",{staticClass:"align-self-start mr-3",staticStyle:{"max-height":"100px"},attrs:{src:a.Image,alt:a.Title}}),s("div",{staticClass:"d-flex w-100 justify-content-between"},[s("h5",{staticClass:"mb-1"},[t._v(t._s(a.Title))]),s("small",[t._v(t._s(a.Class))])]),s("p",{staticClass:"mb-1"},[t._v(t._s(a.Description))]),s("small",[t._v(t._s(a.University))])])}))])},o=[],i=(s("cadf"),s("551c"),s("097d"),{name:"Book",props:["term"],data:function(){return{books:[]}},mounted:function(){var t=this.$route.params.term,a=this;this.$http.post("/v1/search",{query:t}).then(function(t){a.books=t.data})}}),r=i,n=s("2877"),l=Object(n["a"])(r,e,o,!1,null,"2c66c1b2",null);a["a"]=l.exports}});
//# sourceMappingURL=app.c52ee8ff.js.map