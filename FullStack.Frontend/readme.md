



### create-react-app

```
npm uninstall --global create-react-app
npx create-react-app sample

$ yarn create react-app antd-demo
# or
$ npx create-react-app antd-demo
yarn add antd
```

### eject[#](https://ant.design/docs/react/use-with-create-react-app-cn#eject)

你也可以使用 create-react-app 提供的 [yarn run eject](https://create-react-app.dev/docs/available-scripts/#npm-run-eject) 命令将所有内建的配置暴露出来。不过这种配置方式需要你自行探索，不在本文讨论范围内。



 npm install -g cnpm --registry= https://registry.npm.taobao.org 





npm install -g cnpm --registry=https://registry.npm.taobao.org 

 进入项目  cd 【路径自己打】 

npm i  
 安装/还原  node 等 package.json 的 指定插件

 



###  启动的默认ip和端口号



https://blog.csdn.net/sllailcp/article/details/80661250?utm_medium=distribute.pc_relevant.none-task-blog-BlogCommendFromMachineLearnPai2-1.channel_param&depth_1-utm_source=distribute.pc_relevant.none-task-blog-BlogCommendFromMachineLearnPai2-1.channel_param

 在package.json中修改

默认配置：

"start": "react-scripts start",

修改后的配置：

"start": "set PORT=9000 HOST=192.168.1.109 && react-scripts start",



然后启动:npm start 在浏览器中访问http://192.168.1.109:9000/即可

### 5.启动项目  

   npm start   



You can now view dg-cube-core in the browser.    

  Local:            http://localhost:3000        
  On Your Network:  http://10.61.8.155:3000      

Note that the development build is not optimized.
To create a production build, use yarn build.    





### 虚拟DOM（Virtual DOM）



https://www.jianshu.com/p/78f6e3ba6842

使用方式就是**用JS模拟DOM结构，计算出最小的变更，操作DOM**。