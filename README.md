<!DOCTYPE html>
<html>
  <head>
   
  </head>
  <body>
    <h1>Unity-Blackboard Integration</h1>
    <p>This project provides a way to integrate Unity game engine with Blackboard LMS, allowing game developers to create games that can be imported into Blackboard and used as educational tools for students. With this integration, students can play games and their progress can be tracked and monitored by teachers from Blackboard.</p>
    <h2>Getting Started</h2>
    <p>To get started with this project, you will need to have Unity installed on your computer. You can download Unity from the official website <a href="https://unity.com/" target="_blank">here</a>.</p>
    <p>You will also need to have access to Blackboard LMS. You can learn more about Blackboard and how to get started with it on their website <a href="https://www.blackboard.com/" target="_blank">here</a>.</p>
    <h2>Blackboard Access</h2>
    <p>To get an access to the Blackboard, you will need to have the following information:</p>
    <ul>
      <li>URL: <a href="[nameofuniversity.blackboard.com]">nameofuniversity.blackboard.com</a> (example)</li>
      <li>Application Key (Username): <code>[fa5233df-5c24-49bq-aa0b-a37fesdyeb0e]</code> (example)</li>
      <li>Secret (Password): <code>[nKJvFEVmJTjDFgIBev17DefKO4RY0a3j]</code> (example)</li>
    </ul>
    <p>You can get an access to mentioned information above by contacting the IT Help Desk of the University.</p>
    <p>In our project, our university built a sandbox for us and all testing was conducted within the given sandbox.</p>
    <h2>Unity</h2>
    <p>During the project 2021.3.15f1 version of Unity and Visual Studio 2022 were used.</p>
    <p>The project was designed in UWP (Universal Windows Platform).</p>
    <p>Thus, when you want to build it please switch it to UWP.</p>
    <h2>Usage</h2>
    <h3>Folders</h3>
    <ul>
      <li>APIPackage and IntegrationPackage.unitypackage - is our "pure" package where you will get all the available API and can build your own game from scratch by using scripts inside the folder.</li>
      <li>Final Version - is our demo game that demonstrates the connection between Unity and Blackboard.</li>
    </ul>
    <h3>Steps to import and build Demo Game into your computer</h3>
    <ol>
      <li>Download our zip file into your computer and extract it.</li>
      <li>Open Unity Hub and then click <b>OPEN</b> button from the top right side of the application.</li>
      <li>Select Final Version folder.</li>
      <li>Click on Scenes folder and double click on Level1.</li>
      <li>Go to File> Build Settings> Universal Windows Platform.</li>
      <li>Click Development Build and Script Debugging.</li>
      <li>Build.</li>
    </ol>
    <h3>Run Demo Game</h3>
    <ol>
      <li>Open .sln file (you can find it inside the folder that you built).</li>
      <li>Click local machine on the upper middle side of the screen (if not, then you can change it into local machine).</li>
      <li>You are good to go.</li>
    </ol>
    <h2>Resources</h2>
    <ul>
      <li><a href="https://unity.com/" target="_blank">Unity website</a></li>
      <li><a href="https://assetstore.unity.com/" target="_blank">Unity Asset Store</a></li>
      <li><a href="https://sketchfab.com/" target="_blank">Sketchfab</a></li>
      <li><a href="https://mixkit.co/" target="_blank">mixkit</a></li>
      <li><a href="https://www.blackboard.com/" target="_blank">Blackboard website</a></li>
      <li><a href="https://community.blackboard.com/community/developers" target="_blank">Blackboard Developer Community</a></li>
    </ul>
  </body>
</html>
