











### 一张图，帮你总结React入门必须的知识点





https://juejin.im/post/6844903798712827912



![img](readme.assets/1698c45098172f43)





 Formik 3

### create-react-app

https://blog.csdn.net/weixin_39430411/article/details/103771361



 推荐使用`Create React App`。它在内部使用了webpack和Babel，而你无需了解他们的任何细节。 使用如下命令：

```bash
npx create-react-app my-app
```

​    注意这里是`npx` 而不是`npm` ，它是指npm附带的package运行工具。
​     开发环境使用`npm start`，生产环境使用`npm run build`，它会生成一个优化版本。
​     生产环境需要正确配置，比如不显示源码等。

### **render**：

根据一系列的 **diff** 算法，生成需要更新的虚拟 **DOM** 数据



### 组件的生命周期

原文出自：[www.hangge.com](https://www.hangge.com) 转载请保留原文链接：https://www.hangge.com/blog/cache/detail_1473.html

**constructor**

Hooks 



##### Mounting 

##### Updateing

##### Unmounting 

##### Error Handling

https://www.cnblogs.com/wangpenghui522/p/6214953.html

组件生命周期大致分为三个阶段：

第一阶段：是组件第一次绘制阶段，如图中的上面虚线框内，在这里完成了组件的加载和初始化；
第二阶段：是组件在运行和交互阶段，如图中左下角虚线框，这个阶段组件可以处理用户交互，或者接收事件更新界面；
第三阶段：是组件卸载消亡的阶段，如图中右下角的虚线框中，这里做一些组件的清理工作。

React Tutorial: An Overview and Walkthrough

### Form表单



可以尝试使用 ***Formik*** 来作为表单的成熟方案


##### Yup添加验证







### Topic

https://blog.csdn.net/yangxiaobo118/article/details/79823561



基本内容：

1、React

2、npm

3、JavaScript 打包工具

4、ES6

5、路由

6、Flux



进阶话题：

1、内联样式

2、服务端渲染

3、Immutable.js

4、Relay, Falcor等







---





redux-logger



redux-thunk

###  yarn add   mobx --save  



## 故障

控制台运行webpack/npm时出现

```bash
Module not found: Error: Can't resolve 'XXX' in 'XXXX'
1
```

## 解决方案

```bash
npm i XXX --save
yarn add   mobx --save  
```

重新运行即可
 如果提示`ERROR`
 尝试执行

```bash
npm uninstall XXX
npm i XXX --save
```

```csharp
yarn add redux --save
yarn add   mobx --save
     yarn add   react-router-dom --save
     yarn add redux-thunk --save    
    yarn add redux-logger --save
```

npx browserslist@latest --update-db

nd: `npx browserslist --update-db`

caniuse-lite is outdated. Please run the following command: `npx browserslist --update-db`



###  yarn add formik
https://formik.org/docs/overview
NPM

 npm install formik --save