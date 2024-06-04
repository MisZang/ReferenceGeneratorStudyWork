# 简易参考文献生成器 项目介绍

## 项目背景
在学术研究和论文写作过程中，生成和管理参考文献是一个重要但繁琐的任务。简易参考文献生成器 项目旨在简化这一过程，提供一个工具，通过API获取文献信息，并生成格式化的参考文献。

## 项目功能
- **API数据获取**：用户可以通过输入DOI或论文标题，从Springer API获取相关文献信息。
- **文献信息展示**：获取到的文献信息将以列表形式展示，用户可以选择需要的文献。
- **参考文献生成**：选中的文献信息可以生成格式化的参考文献，显示在界面上。
- **API Key管理**：用户可以输入、保存和加载API Key，以便访问Springer API。

## 技术细节
- **编程语言**：C#
- **开发环境**：SharpDevelop IDE
- **主要库和技术**：
  - System.Net.Http：用于执行HTTP请求，从API获取数据。
  - Newtonsoft.Json：用于解析JSON数据。
  - System.Windows.Forms：用于创建和管理窗体界面。
  - System.IO：用于文件的读写操作。

## 使用方法
1. **启动程序**：运行生成的exe文件，启动Reference Generator程序。
2. **输入查询信息**：
   - 在查询文本框中输入DOI或论文标题。
   - 在API Key文本框中输入有效的API Key。
3. **获取文献信息**：点击“查询”按钮，程序将通过API获取文献信息，并显示在列表中。
4. **生成参考文献**：选择列表中的文献，点击“生成引用”按钮，程序将生成格式化的参考文献，显示在文本框中。
5. **管理API Key**：
   - 点击“保存API Key”按钮，可以将输入的API Key保存到文件中。
   - 下次启动程序时，API Key将自动加载。

## 示例截图
暂无（就是一个作业）
